using System.Collections.Generic;
using TicTacToeEngine;

namespace TicTacToeTest
{
    public static class FakePlaySeries
    {
        public static List<Position> XWinsWithThreeXsAtColumnZero =>
            new List<Position>
            {new Position(0, 0), new Position(1, 0), new Position(0, 1),
                new Position(1, 1), new Position(0, 2)};

        public static List<Position> XWinsWithThreeXsAtRowZero =>
            new List<Position>
            {new Position(0, 0), new Position(1,2), new Position(1, 0),
                new Position(1, 1), new Position(2, 0)};

        public static List<Position> XWinsWithThreeXsAtFirstDiagonal =>
            new List<Position>
            {new Position(0, 0), new Position(1,2), new Position(1, 1),
                new Position(1, 0), new Position(2, 2)};

        public static List<Position> XWinsWithThreeXsAtSecondDiagonal =>
            new List<Position>
            {new Position(0, 2), new Position(1,2), new Position(1, 1),
                new Position(1, 0), new Position(2, 0)};

        public static List<Position> OWinsWithThreeOsAtColumnOne =>
            new List<Position>
            {new Position(0, 0), new Position(1, 0), new Position(0, 1),
                new Position(1, 1), new Position(2, 0), new Position(1, 2)};

        public static List<Position> OWinsWithThreeOsAtRowTwo =>
            new List<Position>
            {new Position(0, 0), new Position(1,2), new Position(1, 0),
                new Position(0, 2), new Position(0,1), new Position(2, 2)};

        public static List<Position> PlayTwiceSecondAtOneOne =>
            new List<Position>
            {new Position(0, 0), new Position(1, 1)};

        public static List<Position> PlayOnceAtZeroZero =>
            new List<Position> { new Position(0, 0) };
    }
}