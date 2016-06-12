package tictactoe;

public class TicTacToeGame {
  private static final String PLAYER_X = "X";
  private static final String PLAYER_O = "O";

  private String[][] board = new String[][] {
      { " ", " ", " " },
      { " ", " ", " " },
      { " ", " ", " " }
  };
  private String lastPlayer = "";

  public void playAt(int x, int y) {
    if (lastPlayer == PLAYER_X) {
      lastPlayer = PLAYER_O;
    } else {
      lastPlayer = PLAYER_X;
    }

    board[x][y] = lastPlayer;
  }

  public String winner() {
    if (checkIfGameIsWonByPlayer(lastPlayer)) return lastPlayer;

    return "Game in progress - No winner yet!";
  }

  private boolean checkIfGameIsWonByPlayer(String player) {
    return (boardAt(0, 0).equals(player) &&
        boardAt(0, 1).equals(player) &&
        boardAt(0, 2).equals(player)) ||
        (boardAt(0, 0).equals(player) &&
            boardAt(1, 0).equals(player) &&
            boardAt(2, 0).equals(player))||
        (boardAt(0, 0).equals(player) &&
            boardAt(1, 1).equals(player) &&
            boardAt(2, 2).equals(player));
  }

  public String boardAt(int x, int y) {
    return board[x][y];
  }
}
