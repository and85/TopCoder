namespace RPN
{
    public class RPN
    {
        public delegate int BinaryOperationsDelegate(int arg1, int arg2);
        public delegate int UnaryOperationsDelegate(int arg1);

        public int evaluate(string expr)
        {
            int malformedExpressionResult = -999;
            int result = 0;

            var resultStack = new System.Collections.Generic.Stack<int>();
            
            try
            {
                for (int i = 0; i < expr.Length; i++)
                {
                    char currentCharacter = expr[i];

                    if (System.Char.IsWhiteSpace(currentCharacter))
                        continue;

                    switch (currentCharacter)
                    {
                        case '+':
                            BinaryOperations(resultStack, Addition);
                            break;
                        case '-':
                            BinaryOperations(resultStack, Subtraction);
                            break;
                        case '*':
                            BinaryOperations(resultStack, Multiplication);
                            break;
                        case '~':
                            UnaryOperations(resultStack, UnaryNegation);
                            break;
                        default:
                            var value = int.Parse(currentCharacter.ToString());
                            resultStack.Push(value);
                            break;
                    }
                }
            }
            catch (System.ArgumentException)
            {
                result = malformedExpressionResult;
            }
            finally
            {
                result = ExtractResult(malformedExpressionResult, result, resultStack);
            }

            return result;
        }

        private static int ExtractResult(int malformedExpressionResult, int result, System.Collections.Generic.Stack<int> resultStack)
        {
            // the only correct outcome
            if (resultStack.Count == 1 && result != malformedExpressionResult)
            {
                result = resultStack.Peek();
            }
            else
            {
                result = malformedExpressionResult;
            }

            return result;
        }

        private void BinaryOperations(System.Collections.Generic.Stack<int> inputStack, BinaryOperationsDelegate delagate)
        {
            if (inputStack.Count >= 2)
            {
                int arg2 = inputStack.Pop();
                int arg1 = inputStack.Pop();

                int result = delagate(arg1, arg2);
                inputStack.Push(result);
            }
            else
            {
                throw new System.ArgumentException();
            }
        }

        private void UnaryOperations(System.Collections.Generic.Stack<int> inputStack, UnaryOperationsDelegate delagate)
        {
            if (inputStack.Count >= 1)
            {
                int arg1 = inputStack.Pop();

                int result = -arg1;
                inputStack.Push(result);
            }
            else
            {
                throw new System.ArgumentException();
            }
        }

        private int Addition(int arg1, int arg2)
        {
            return arg1 + arg2;
        }

        private int Subtraction(int arg1, int arg2)
        {
            return arg1 - arg2;
        }

        private int Multiplication(int arg1, int arg2)
        {
            return arg1 * arg2;
        }

        private int UnaryNegation(int arg1)
        {
            return -arg1;
        }
    }
}
