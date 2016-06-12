package tictactoe;

public class TicTacToeGame {
  private static final String PLAYER_X = "X";
  private static final String PLAYER_O = "O";

  private static final int FIRST_ROW = 0;

  private String[][] board = new String[][] {
      { " ", " ", " " },
      { " ", " ", " " },
      { " ", " ", " " }
  };
  private String lastPlayer = "";

  public void playAt(int x, int y) {
    if (lastPlayer.equals(PLAYER_X)) {
      lastPlayer = PLAYER_O;
    } else {
      lastPlayer = PLAYER_X;
    }

    board[x][y] = lastPlayer;
  }

  public String winner() {
    if (checkIfGameIsWonByPlayer(lastPlayer)) {
      return lastPlayer;
    }

    return "Game in progress - No winner yet!";
  }

  private boolean checkIfGameIsWonByPlayer(String player) {
    if (rowIsTicked(FIRST_ROW, player)) return true;
    if (rowIsTicked(1, player)) return true;

    for (int column = 0; column < 3; column++) {
      if (columnIsTicked(column, player)) {
        return true;
      }
    }

    if (topLeftToBottomRightDiagonalIsTicked(player)) return true;
    if (topRightToBottomLeftDiagonalIsTicked(player)) return true;
    return false;
  }

  private boolean rowIsTicked(int row, String player) {
    return boardAt(0, row).equals(player) &&
        boardAt(1, row).equals(player) &&
        boardAt(2, row).equals(player);
  }

  private boolean topRightToBottomLeftDiagonalIsTicked(String player) {
    return boardAt(2, 0).equals(player) &&
        boardAt(1, 1).equals(player) &&
        boardAt(0, 2).equals(player);
  }

  private boolean topLeftToBottomRightDiagonalIsTicked(String player) {
    return boardAt(0, 0).equals(player) &&
        boardAt(1, 1).equals(player) &&
        boardAt(2, 2).equals(player);
  }

  private boolean columnIsTicked(int column, String player) {
    return boardAt(column, 0).equals(player) &&
        boardAt(column, 1).equals(player) &&
        boardAt(column, 2).equals(player);
  }

  public String boardAt(int x, int y) {
    return board[x][y];
  }
}
