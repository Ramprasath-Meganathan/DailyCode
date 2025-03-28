public class ValidSudoku {

    // 36. Valid Sudoku
    // Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:
    // Each row must contain the digits 1-9 without repetition.
    // Each column must contain the digits 1-9 without repetition.
    // Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
    // Note:
    // A Sudoku board (partially filled) could be valid but is not necessarily solvable.
    // Only the filled cells need to be validated according to the mentioned rules.
    // Example 1:
    // Input: board =
    // [["5","3",".",".","7",".",".",".","."]
    // ,["6",".",".","1","9","5",".",".","."]
    // ,[".","9","8",".",".",".",".","6","."]
    // ,["8",".",".",".","6",".",".",".","3"]
    // ,["4",".",".","8",".","3",".",".","1"]
    // ,["7",".",".",".","2",".",".",".","6"]
    // ,[".","6",".",".",".",".","2","8","."]
    // ,[".",".",".","4","1","9",".",".","5"]
    // ,[".",".",".",".","8",".",".","7","9"]]
    // Output: true
    // Example 2:
    // Input: board =
    // [["8","3",".",".","7",".",".",".","."]
    // ,["6",".",".","1","9","5",".",".","."]
    // ,[".","9","8",".",".",".",".","6","."]
    // ,["8",".",".",".","6",".",".",".","3"]
    // ,["4",".",".","8",".","3",".",".","1"]
    // ,["7",".",".",".","2",".",".",".","6"]
    // ,[".","6",".",".",".",".","2","8","."]
    // ,[".",".",".","4","1","9",".",".","5"]
    // ,[".",".",".",".","8",".",".","7","9"]]
    // Output: false
    // Explanation: Same as Example 1, except with the 5 in the top left corner being modified to 8. Since there are two 8's in the top left 3x3 sub-box, it is invalid.
    // Constraints:
    // board.length == 9
    // board[i].length == 9
    // board[i][j] is a digit or '.'.
    //
    // O(1) time and O(1) space
    public bool IsValidSudoku(char[][] board) {
        for(int i = 0; i < 9; i++)
        {
            HashSet<char> seen = new HashSet<char>();
            for(int j = 0 ; j< 9 ; j++)
            {
                char c = board[i][j];
                if(c!='.')
                {
                    if(seen.Contains(c))
                        return false;
                    seen.Add(c);
                }
            }
        }

        for(int j = 0; j<9; j++)
        {
            HashSet<char> seen = new HashSet<char>();
            for(int i = 0; i < 9; i++)
            {
                char c = board[i][j];
                if(c!='.')
                {
                    if(seen.Contains(c))
                        return false;
                    seen.Add(c);
                }
            }
        }

        for(int block = 0; block <9 ; block++)
        {
            HashSet<char> seen = new HashSet<char>();
            int rowOffset = (block/3)*3;
            int colOffset = (block%3)*3;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j< 3; j++)
                {
                char c = board[rowOffset+i][colOffset+j];
                if(c!='.')
                {
                    if(seen.Contains(c))
                        return false;
                    seen.Add(c);
                }
                }
            }
        }
        return true;
    }

    // O(1) time and O(1) space
    public bool IsValidSudokuOptimized(char[][] board)
    {
        HashSet<string>[] rows = new HashSet<string>[9];
        HashSet<string>[] cols = new HashSet<string>[9];
        HashSet<string>[] boxes = new HashSet<string>[9];
        for(int i = 0; i < 9; i++)
        {
            rows[i] = new HashSet<string>();
            cols[i] = new HashSet<string>();
            boxes[i] = new HashSet<string>();
        }
        for(int i = 0; i< 9; i++)
        {
            for(int j = 0; j<9; j++)
            {
                char c = board[i][j];
                if(c=='.')
                    continue;
                int boxIndex = (i/3)*3 + j/3;
                if(rows[i].Contains(c) || cols[j].Contains(c) || boxes[boxIndex].Contains(c))
                    return false;
                rows[i].Add(c);
                cols[j].Add(c);
                boxes[boxIndex].Add(c);
            }
        }
        return true;
    }
}