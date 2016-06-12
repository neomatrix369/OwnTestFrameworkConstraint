package tictactoe;

/**
 * Unit test for simple TicTacToeGameTestRunner.
 */
public class TicTacToeGameTestRunner {

  private static TicTacToeGame game;

  public static void main(String[] args) {
    x_plays_at_0_0();
    x_and_o_play_one_after_the_other();
    game_in_progress_no_winner();
    x_wins_the_game();
  }



  private static void x_plays_at_0_0() {
    createATicTacToeGame();

    playAt(0, 0);

    boardStateAtPositionIs(0, 0, "X");
  }

  private static void x_and_o_play_one_after_the_other() {
    createATicTacToeGame();

    playAt(0, 0);
    playAt(1, 1);

    boardStateAtPositionIs(1, 1, "O");
  }

  private static void game_in_progress_no_winner() {
    createATicTacToeGame();

    playAt(0, 0);

    gameWinnerShouldBe("Game in progress - No winner yet!");
  }

  private static void x_wins_the_game() {
    throw new UnsupportedOperationException();
  }

  private static void createATicTacToeGame() {
    game = new TicTacToeGame();
  }

  private static void playAt(int x, int y) {
    game.playAt(x, y);
  }

  private static void boardStateAtPositionIs(int x, int y, String expectedBoardState) {
    final String failureMessage = "expected " + expectedBoardState
        + " to play at " + x + ", " + y + " and found "
        + game.boardAt(x, y) + " at this position";

    final String successMessage = expectedBoardState + " played at " + x + ", " + y;

    assertTrue(game.boardAt(x, y) == expectedBoardState,
        successMessage, failureMessage);
  }

  private static void gameWinnerShouldBe(String expectedWinner) {
    String successMessage = "Game winner is: " + expectedWinner;
    String failureMessage = "Expected winner was " + expectedWinner +
        " but winner was " + game.winner();

    assertTrue(game.winner() == expectedWinner,
        successMessage, failureMessage);
  }

  private static void displayFailureMessage(String failureMessage) {
    System.out.println("Failure: " + failureMessage);
  }

  private static void displaySuccessMessage(String successMessage) {
    System.out.println("Success: " + successMessage);
  }

  private static void assertTrue(boolean condition, String successMessage, String failureMessage) {
    if (condition) {
      displaySuccessMessage(successMessage);
    } else {
      displayFailureMessage(failureMessage);
    }
  }
}
