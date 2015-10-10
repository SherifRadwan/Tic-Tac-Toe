using System;
using System.Collections;

namespace XO_Game
{
	// and what is NY? !!
	// names arn't so good?
    public enum Player { NY, Player1, Player2 };
    public enum PlayChar { NY, X, O };

    public class Game
    {

        private Player playerTurn;
        public Player PlayerTurn 
        {
            get
            {
                return playerTurn;
            }
        }

        public Player NextTurn 
        {
            // FIXME:
            // use bool or % to reverse turn
            // bool is uses less memory
            // TODO: 
            // is char more than int in enum?
            get
            {
                if (playerTurn == Player.Player1)
                    return Player.Player2;
                else
                    return Player.Player1;
            }
        }

        private Player winner;
        public Player Winner
        { 
            get 
            { 
                return winner;
            } 
        }

        public PlayChar PlayerChar
        {
            get
            {
                if (playerTurn == Player.Player1)
                    return PlayChar.X;
                else
                    return PlayChar.O;
            }
        }

        // a 3x3 board
        private PlayChar[,] board;
        private Random random;
		// is plays is an english plural of play?
        private int plays;
		// TODO:
		// use property for e.g. Winner
		// and may be make a class for Player
		// set name and other data for player
		// and derive a Computer player
		// with the computer name (abom-box for example)

        public Game()
        {
            reset();
            random = new Random();
        }

        // reset game
        public void reset()
        {
            // board now is empty
            // i.e. is filled with nulls
            board = new PlayChar[3, 3];
            playerTurn = Player.Player1;
            winner = Player.NY;
            plays = 0;
        }

		// re arrange private and public areas
		// use properties (every thing you learned at the lab!)

        public bool isCompleted()
        {
            return plays == 9 || winner != Player.NY;
        }

        // set x or o at a specific position
        public void play(int r, int c)
        {
            if (isCompleted())
            {
                //reset();
                return;
            }

            // TODO:
            // check for r and c ranges
            board[r, c] = PlayerChar;
            plays++;
            checkWinner();
            playerTurn = NextTurn;
        }

        // play by the number of the cell
        public void play(int n)
        {
            int r, c;

            r = n / 3;
            c = n % 3;

            play(r, c);
        }

		// the following three method could be combined into one?
		// isAnyCompleted() or something like that?
        private bool isRowCompleted(int row)
        {
            int i, count = 0;
     
            for (i = 0; i < 3; i++)
                if (board[i, row] == PlayerChar) count++;

            return count == 3;
        }

        private bool isColumnCompleted(int column)
        {
            int i, count = 0;
     
            for (i = 0; i < 3; i++)
                if (board[column, i] == PlayerChar) count++;

            return count == 3;
        }

        private bool isDiagonalCompleted()
        {
            int i, count1 = 0, count2 = 0;

            for (i = 0; i < 3; i++)
                if (board[i, i] == PlayerChar) count1++;

            if (count1 == 3)
                return true;

			// the following loop could be combined with
			// the previous one (and the previous functions also)
			// just figure a way to the series
			// 0,2 , 1,1 , 2,0 :D
            // 
            //for (i = 2; i > 0; i--)
            //    if (board[i, i % 2] == PlayerChar) count2++;  
            if (board[0, 2] == PlayerChar) count2++;
            if (board[1, 1] == PlayerChar) count2++;
            if (board[2, 0] == PlayerChar) count2++;

            return count2 == 3;
        }

        // check for winner
        public void checkWinner()
        {
            // if plays < 5, no need to check
            if (plays < 5)
            {
                winner = Player.NY;
                return;
            }

            if(isDiagonalCompleted())
            {
                winner = playerTurn;
                return;
            }

            for (int i = 0; i < 3; i++)
            {
                if (isRowCompleted(i) || isColumnCompleted(i))
                {
                    winner = playerTurn;
                    return;
                }
            }

            winner = Player.NY;
        }

        public int randomPlay()
        {
            if (isCompleted())
                return -1;

            int count = -1;
            // may use an array of size 9
			// private int[] a = new int[9];
			// and add to it and stop at null or count
			ArrayList empty = new ArrayList();

            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    count++;
                    if (board[r, c] == PlayChar.NY)
						// a[count++] = count; // or somthing like that
                        empty.Add(count);
                }
            }

            int randIndedx, randPlace;
            randIndedx = random.Next(0, empty.Count - 1);
            randPlace = (int) empty[randIndedx];
            play(randPlace);

            return randPlace;
        }
    }
}
