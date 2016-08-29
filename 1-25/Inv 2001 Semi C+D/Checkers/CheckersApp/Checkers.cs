namespace CheckersApp
{
    public class Checkers
    {
        private int _fieldSize = 8;

        public int compute(string startPos, string[] pieces)
        {
            var field = new bool[_fieldSize, _fieldSize];
            
            foreach (string piece in pieces)
            {
                field[GetX(piece), GetY(piece)] = true;
            }

            int curX = GetX(startPos);
            int curY = GetY(startPos);
            int nextX = 0;
            int nextY = 0;

            int movesCounter = 0;

            while (!EndOfBoardY(curY + 1))
            {
                if (MakeMove(field, curX, curY, ref nextX, ref nextY))
                {
                    movesCounter++;

                    curX = nextX;
                    curY = nextY;
                }
                else
                    return -1;
            }

            return movesCounter;
        }

        private bool MakeMove(bool[,] field, int curX, int curY, ref int nextX, ref int nextY)
        {
            // we should decide if we want to go left (curX - 1) or right (curX + 1)
            int leftEstimate = Estimate(field, curX, curY, -1);
            int rightEstimate = Estimate(field, curX, curY, 1);

            if (leftEstimate == 0 && rightEstimate == 0)
            {
                return false;
            }

            if (leftEstimate > rightEstimate)
            {
                // go left
                nextX = curX - leftEstimate;
                nextY = curY + leftEstimate;
            }
            else
            {
                // go right
                nextX = curX + rightEstimate;
                nextY = curY + rightEstimate;
            }
             
            return true;
        }

        /// <summary>
        /// Returns amount of rows how far we will get if we decide to go left
        /// Checks only one move, is not able to predict further locations of black pieces
        /// </summary>
        private int Estimate(bool[,] field, int curX, int curY, int direction)
        {
            int result = 0;

            // define a type of our move, it could be eather a jump or an ordinary move
            int nextX = curX + direction;
            int nextY = curY + 1;

            // if we have a black piece in the next cell, we will always have to jump, otherwise we will have to make just ordinary moves
            bool isJump = field[nextX, nextY];

            if (isJump)
            {
                // define how many jumps we can make
                result = JumpForward(field, curX, curY, 2, direction);
            }
            else
            {
                // define how many ordinary moves we can make
                result = 1;
            }

            return result;
        }

        private int JumpForward(bool[,] field, int curX, int curY, int step, int direction)
        {
            int result = 0;

            int counter = step;
            while (true)
            {
                int x = curX + direction*counter;
                int y = curY + counter;

                // we can't go further if we have reached end of the board or a next field contains a black piece
                // or it doesn't make sense to continue jumping
                if (EndOfBoardX(x) || EndOfBoardY(y) || field[x, y] || !field[x - direction, y - 1])
                {
                    result = counter - step;
                    break;
                }

                counter = counter + step;
            }
            return result;
        }

        private bool EndOfBoardX(int x)
        {
            return x < 0 || x > _fieldSize - 1;
        }

        private static int GetY(string position)
        {
            return int.Parse(position[2].ToString());
        }

        private static int GetX(string position)
        {
            return int.Parse(position[0].ToString());
        }

        private bool EndOfBoardY(int curY)
        {
            return curY > _fieldSize - 1;
        }
    }
}