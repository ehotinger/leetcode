// https://leetcode.com/problems/rotate-image/

// [1,2,3]
// [4,5,6]
// [7,8,9]

// [7,4,1]
// [8,5,2]
// [9,6,3]

// length: 2
// temp = 1

// 1 => 7
// 7 => 9
// 9 => 3
// 3 => 1

// 1 7 9 3
// i => 0, j => 0
// [0,0], [2,0], [2,2], [0,2]

// want: 2 4 8 6
// i => 1, j => 1
// [0,1], [1,0], [2,1], [1,2]

public class Solution {
    public void Rotate(int[][] matrix) {
        var length = matrix.GetLength(0) - 1;
        for(int i = 0; i <= length / 2; i++) {
            for(int j = i; j < length - i; j++) {
                var temp = matrix[i][j];
                // Console.WriteLine(matrix[i][j]);
                // Console.WriteLine(matrix[length-j][i]);
                // Console.WriteLine(matrix[length-i][length-j]);
                // Console.WriteLine(matrix[j][length-i]);

                matrix[i][j] = matrix[length-j][i];
                matrix[length-j][i] = matrix[length-i][length-j];
                matrix[length-i][length-j] = matrix[j][length-i];
                matrix[j][length-i] = temp;
                Console.WriteLine("----");
            }
        }
    }
}