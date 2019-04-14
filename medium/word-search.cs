// https://leetcode.com/problems/word-search/
public class Solution {
    public bool Exist(char[][] board, string word) {
        for(int i = 0; i < board.Length; i++) {
            for(int j = 0; j < board[i].Length; j++) {
                if(board[i][j] == word[0]) {
                    if(DFS(board, i, j, word, 0)) {
                        return true;
                    }
                }
            }
        }
        
        return false;
    }
    
    public bool DFS(char[][] board, int i, int j, string word, int index) {
        if(index == word.Length) return true;
        if(i < 0 || j < 0 || i == board.Length || j == board[i].Length) return false;
        if(board[i][j] != word[index]) return false;
        board[i][j] = (char)(board[i][j] ^ 500); // Mark the tile as used to save space.
        var exists = DFS(board, i, j-1, word, index+1) || 
                     DFS(board, i-1, j, word, index+1) ||
                     DFS(board, i+1, j, word, index+1) ||
                     DFS(board, i, j+1, word, index+1);
        board[i][j] = (char)(board[i][j] ^ 500); // Allow reusing the tile after we've scanned for it.
        return exists;
    }
}