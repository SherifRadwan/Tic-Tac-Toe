using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace XO_Game
{
    public partial class frmMain : Form
    {
        // to do an operation on button
        // and used with applyToBoard
        public delegate void doOnBtn(Button btn);

        public frmNameInput dlgName = new frmNameInput();

        private Game game = new Game();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: reset and remove the default focus of all buttons
            applyToBoard(setEvenetHandler);
            gameReset();
        }

        public void applyToBoard(doOnBtn func)
        {
            foreach (Control control in pnlBoard.Controls)
                if (control.GetType().Name == "Button")
                    func((Button) control);
        }

        public void clearBtn(Button btn)
        {
            btn.Text = "";
            btn.Enabled = true;
        }

        public void setEvenetHandler(Button btn)
        {
            btn.Click += new System.EventHandler(gamePlay);
        }

        public void setCurrentTurn()
        {
            lblCurrentTurn.Text = "Turn: ";

            if (game.PlayerTurn == Player.Player1)
                lblCurrentTurn.Text += lblName1.Text;
            else
                lblCurrentTurn.Text += lblName2.Text;
        }

        public void gameReset(bool clear = true)
        {
            game.reset();
            setCurrentTurn();

            if(clear)
                applyToBoard(clearBtn);

            btnPlay.Show();
            btnStop.Hide();
            lblCurrentTurn.Text = "";
        }

        private int buttonId(Button btn)
        {
            return Convert.ToInt16(Convert.ToString(btn.Name.Last()));
        }

        private Button btnFromId(int id)
        {
            if(id > 8)
                return null;
            else
                foreach(Control control in pnlBoard.Controls)
                {
                    if (control.GetType().Name == "Button")
                        if(buttonId((Button) control) == id)
                            return (Button) control;
                }

            return null;
        }

        public void gamePlay(object sender, EventArgs e)
        {
            // game has not started yet
            if (btnPlay.Visible)
                return;

            Button buttonClicked;

            if (sender == null) // this is the timer
            {
                // play then set button
                int place = game.randomPlay();
                if (place >= 0 && place < 9)
                    buttonClicked = btnFromId(place);
                else
                    return;
            }
            else
            {
                // get button then play with it
                buttonClicked = (Button) sender;
                int n = buttonId(buttonClicked);
                game.play(n);
            }

			// TODO: 
            // remove the current char and check for player
			// then add pictures or any thing else
            if(game.PlayerChar == PlayChar.X)
                buttonClicked.Text = "O";
            else
                buttonClicked.Text = "X";

            buttonClicked.Enabled = false;
            setCurrentTurn();

            if (game.isCompleted())
            {
                if (game.Winner != Player.NY)
                {
                    if (game.Winner == Player.Player1)
                        MessageBox.Show(lblName1.Text + " is the the winner!", "Winner!", MessageBoxButtons.OK);
                    else
                        MessageBox.Show(lblName2.Text + " is the the winner!", "Winner!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("No Winner had won the game!", "No Winner!", MessageBoxButtons.OK);
                }

                gameReset(false);
            }
        }


        private void computerTimer_Tick(object sender, EventArgs e)
        {
            if(game.PlayerTurn == Player.Player2)
                gamePlay(null, null);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            gameReset();

            if (radPlayerVsPlayer.Checked)
                computerTimer.Stop();
            else
                computerTimer.Start();

            setCurrentTurn();
            btnPlay.Hide();
            btnStop.Show();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            computerTimer.Stop();
            gameReset();
            btnPlay.Show();
            btnStop.Hide();
        }

        private void lblName1_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgName.ShowDialog();

            if (r == DialogResult.OK)
                lblName1.Text = "X: " + dlgName.PlayerName;
        }

        private void lblName2_Click(object sender, EventArgs e)
        {
            if (radPlayerVsComputer.Checked)
                return;

            DialogResult r = dlgName.ShowDialog();

            if (r == DialogResult.OK)
                lblName2.Text = "O: " + dlgName.PlayerName;
        }

        private void radPlayerVsComputer_CheckedChanged(object sender, EventArgs e)
        {
            if (radPlayerVsComputer.Checked)
                lblName2.Text = "O: " + SystemInformation.ComputerName;
            else
                lblName2.Text = "O: " + dlgName.PlayerName;
        }

    }
}
