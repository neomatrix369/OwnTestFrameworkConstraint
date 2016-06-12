package tictactoe;

public class TicTacToeGame {
  private String[][] board = new String[][] {
      { " ", " ", " " },
      { " ", " ", " " },
      { " ", " ", " " }
  };
  private String lastPlayer = "";

  public void playAt(int x, int y) {
    if (lastPlayer == "X") {
      lastPlayer = "O";
    } else {
      lastPlayer = "X";
    }

    board[x][y] = lastPlayer;
  }

  public String winner() {
    return "Game in progress - No winner yet!";
  }

  public String boardAt(int x, int y) {
    return board[x][y];
  }
}
