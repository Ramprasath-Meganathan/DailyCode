using System;
using System.Collections.Generic;
using System.Text;

// Time complexity: O(4^n / sqrt(n))
public class GenerateParanthesis {
    public IList<string> GenerateParenthesis(int n) {
        var result = new List<string>();
        BackTrack(result, new StringBuilder(), 0, 0, n);
        return result;
    }

    private void BackTrack(List<string> result, StringBuilder current, int openN, int closedN, int n) {
        if (openN == n && closedN == n) {
            result.Add(current.ToString());
            return;
        }

        if (openN < n) {
            current.Append("(");
            BackTrack(result, current, openN + 1, closedN, n);
            current.Length--;  // Backtrack by removing last char
        }

        if (closedN < openN) { // Fix: closedN should be less than openN
            current.Append(")");
            BackTrack(result, current, openN, closedN + 1, n);
            current.Length--;  // Backtrack by removing last char
        }
    }
}
