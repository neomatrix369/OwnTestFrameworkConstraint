package tictactoe;

import static java.lang.String.*;

/**
 * Unit test for simple TicTacToeGameTestRunner.
 */
public class TicTacToeGameTestRunner {

  private static TicTacToeGame game;

  public static void main(String[] args) {
    x_plays_at_0_0();
    x_and_o_play_one_after_the_other();

    game_in_progress_no_winner();

    x_wins_the_game_by_ticking_all_first_column_positions();
    o_wins_the_game_by_ticking_all_first_column_positions();

    x_wins_the_game_by_ticking_all_second_column_positions();

    x_wins_the_game_by_ticking_all_first_row_positions();
    o_wins_the_game_by_ticking_all_first_row_positions();

    x_wins_the_game_by_ticking_from_the_top_left_to_bottom_right_diagonal_positions();
    o_wins_the_game_by_ticking_from_the_top_right_to_bottom_left_diagonal_positions();
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

  // X --->, Y (vertically)
  // (0,0) (1,0) (2,0)
  //
  // (0,1) (1,1) (2,1)
  //
  // (0,2) (1,2) (2,2)
  //
  private static void x_wins_the_game_by_ticking_all_first_column_positions() {
    createATicTacToeGame();

    playAt(0, 0); // X O O
    playAt(1, 0); //
    playAt(0, 1); // X
    playAt(2, 0); //
    playAt(0, 2); // X

    gameWinnerShouldBe("X");
  }

  private static void o_wins_the_game_by_ticking_all_first_column_positions() {
    createATicTacToeGame();

    playAt(2, 2); // O X X
    playAt(0, 0); //
    playAt(1, 0); // O X
    playAt(0, 1); //
    playAt(2, 0); // O
    playAt(0, 2); //

    gameWinnerShouldBe("O");
  }

  private static void x_wins_the_game_by_ticking_all_second_column_positions() {
    createATicTacToeGame();

    playAt(1, 0); // O X O
    playAt(0, 0); //
    playAt(1, 1); //   X
    playAt(2, 0); //
    playAt(1, 2); //   X

    gameWinnerShouldBe("X");
  }

  private static void x_wins_the_game_by_ticking_all_first_row_positions() {
    createATicTacToeGame();

    playAt(0, 0); // X X X
    playAt(0, 1); //
    playAt(1, 0); // O
    playAt(0, 2); //
    playAt(2, 0); // O

    gameWinnerShouldBe("X");
  }

  private static void o_wins_the_game_by_ticking_all_first_row_positions() {
    createATicTacToeGame();

    playAt(1, 1); // O O O
    playAt(0, 0); //
    playAt(0, 1); // X X
    playAt(1, 0); //
    playAt(0, 2); // X
    playAt(2, 0); //

    gameWinnerShouldBe("O");
  }

  private static void x_wins_the_game_by_ticking_from_the_top_left_to_bottom_right_diagonal_positions() {
    createATicTacToeGame();

    playAt(0, 0); // X O O
    playAt(0, 1); //
    playAt(1, 1); //   X
    playAt(0, 2); //
    playAt(2, 2); //     X

    gameWinnerShouldBe("X");
  }

  private static void o_wins_the_game_by_ticking_from_the_top_right_to_bottom_left_diagonal_positions() {
    createATicTacToeGame();

    playAt(0, 0); //
    playAt(2, 0); // X X O
    playAt(1, 0); //
    playAt(1, 1); //   O
    playAt(2, 2); //
    playAt(0, 2); // O   X

    gameWinnerShouldBe("O");
  }

  private static void createATicTacToeGame() {
    game = new TicTacToeGame();
  }

  private static void playAt(int x, int y) {
    game.playAt(x, y);
  }

  private static void boardStateAtPositionIs(int x, int y, String expectedBoardState) {
    final String failureMessage =
        format("expected %s to play at %d, %d and found %s at this position",
            expectedBoardState, x, y, game.boardAt(x, y));

    final String successMessage = format("%s played at %d, %d", expectedBoardState, x, y);

    assertTrue(game.boardAt(x, y).equals(expectedBoardState), successMessage, failureMessage);
  }

  private static void gameWinnerShouldBe(String expectedWinner) {
    String successMessage = format("Game winner is: %s", expectedWinner);
    String failureMessage =
        format("Expected winner was %s but winner was %s", expectedWinner, game.winner());

    assertTrue(game.winner().equals(expectedWinner),
        successMessage, failureMessage);
  }

  private static void displayFailureMessage(String failureMessage) {
    System.out.printf("Failure: %s%n", failureMessage);
  }

  private static void displaySuccessMessage(String successMessage) {
    System.out.printf("Success: %s%n", successMessage);
  }

  private static void assertTrue(boolean condition, String successMessage, String failureMessage) {
    if (condition) {
      displaySuccessMessage(successMessage);
    } else {
      displayFailureMessage(failureMessage);
    }
  }
}
