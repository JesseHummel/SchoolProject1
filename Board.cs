using System;
using FSPG;

namespace ConsoleApplication5
{
    class Board
    {
        int mX;
        int mY;

        public void mGameBoard(int x, int y)
        {
            mX = x;
            mY = y;
            char[,] mBoard = new char[mX, mY];

        }
    }
}
