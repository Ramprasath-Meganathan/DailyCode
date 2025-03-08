public class EvaluateRPN
{

    // O(n) time and O(n) space
    public int EvalRPN(string[] tokens)
    {
        Stack<int> stack = new Stack<int>(); // O(n) space
        foreach (var str in tokens) // O(n) time
        {
            if (int.TryParse(str, out int number)) // O(1) time
                stack.Push(number); // O(1) time
            else
            {
                int num2 = stack.Pop(); // O(1) time
                int num1 = stack.Pop(); // O(1) time
                int result = 0;
                switch (str)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;
                }
                stack.Push(result);   // O(1) time
            }
        }
        return stack.Pop(); // O(1) time
    }

    public int EvalRPNOptimized(string[] tokens)
    {
        int[] stack = new int[tokens.Length];
        int top = -1;
        foreach (var str in tokens)
        {
            if (int.TryParse(str, out int number))
                stack[++top] = number;
            else
            {
                int num2 = stack[top--];
                int num1 = stack[top--];
                int result = 0;
                switch (str)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;
                }
                stack[++top] = result;
            }
        }
        return stack[top];
    }
}