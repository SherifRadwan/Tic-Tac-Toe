namespace XO_Game
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.computerTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.radPlayerVsPlayer = new System.Windows.Forms.RadioButton();
            this.radPlayerVsComputer = new System.Windows.Forms.RadioButton();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblCurrentTurn = new System.Windows.Forms.Label();
            this.btnAudioOff = new System.Windows.Forms.Button();
            this.btnAudioOn = new System.Windows.Forms.Button();
            this.pnlBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // computerTimer
            // 
            this.computerTimer.Interval = 800;
            this.computerTimer.Tick += new System.EventHandler(this.computerTimer_Tick);
            // 
            // pnlBoard
            // 
            this.pnlBoard.Controls.Add(this.btn2);
            this.pnlBoard.Controls.Add(this.btn7);
            this.pnlBoard.Controls.Add(this.btn1);
            this.pnlBoard.Controls.Add(this.btn8);
            this.pnlBoard.Controls.Add(this.btn0);
            this.pnlBoard.Controls.Add(this.btn5);
            this.pnlBoard.Controls.Add(this.btn3);
            this.pnlBoard.Controls.Add(this.btn4);
            this.pnlBoard.Controls.Add(this.btn6);
            this.pnlBoard.Location = new System.Drawing.Point(12, 27);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(274, 183);
            this.pnlBoard.TabIndex = 11;
            // 
            // btn2
            // 
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(184, 12);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(80, 50);
            this.btn2.TabIndex = 0;
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Location = new System.Drawing.Point(98, 124);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(80, 50);
            this.btn7.TabIndex = 1;
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(98, 12);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(80, 50);
            this.btn1.TabIndex = 8;
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Location = new System.Drawing.Point(184, 124);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(80, 50);
            this.btn8.TabIndex = 2;
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Location = new System.Drawing.Point(12, 12);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(80, 50);
            this.btn0.TabIndex = 7;
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Location = new System.Drawing.Point(184, 68);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(80, 50);
            this.btn5.TabIndex = 3;
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Location = new System.Drawing.Point(12, 68);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(80, 50);
            this.btn3.TabIndex = 6;
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Location = new System.Drawing.Point(98, 68);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(80, 50);
            this.btn4.TabIndex = 4;
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Location = new System.Drawing.Point(12, 124);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(80, 50);
            this.btn6.TabIndex = 5;
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(211, 241);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 12;
            this.btnPlay.Text = "Play!";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(211, 241);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // radPlayerVsPlayer
            // 
            this.radPlayerVsPlayer.AutoSize = true;
            this.radPlayerVsPlayer.Checked = true;
            this.radPlayerVsPlayer.Location = new System.Drawing.Point(12, 247);
            this.radPlayerVsPlayer.Name = "radPlayerVsPlayer";
            this.radPlayerVsPlayer.Size = new System.Drawing.Size(106, 17);
            this.radPlayerVsPlayer.TabIndex = 14;
            this.radPlayerVsPlayer.TabStop = true;
            this.radPlayerVsPlayer.Text = "Player Vs. Player";
            this.radPlayerVsPlayer.UseVisualStyleBackColor = true;
            // 
            // radPlayerVsComputer
            // 
            this.radPlayerVsComputer.AutoSize = true;
            this.radPlayerVsComputer.Location = new System.Drawing.Point(12, 270);
            this.radPlayerVsComputer.Name = "radPlayerVsComputer";
            this.radPlayerVsComputer.Size = new System.Drawing.Size(123, 17);
            this.radPlayerVsComputer.TabIndex = 15;
            this.radPlayerVsComputer.TabStop = true;
            this.radPlayerVsComputer.Text = "Player Vs. Computer";
            this.radPlayerVsComputer.UseVisualStyleBackColor = true;
            this.radPlayerVsComputer.CheckedChanged += new System.EventHandler(this.radPlayerVsComputer_CheckedChanged);
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Location = new System.Drawing.Point(30, 11);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(59, 13);
            this.lblName1.TabIndex = 16;
            this.lblName1.Text = "X: Player 1";
            this.lblName1.Click += new System.EventHandler(this.lblName1_Click);
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Location = new System.Drawing.Point(215, 11);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(61, 13);
            this.lblName2.TabIndex = 17;
            this.lblName2.Text = "O: Player 2";
            this.lblName2.Click += new System.EventHandler(this.lblName2_Click);
            // 
            // lblCurrentTurn
            // 
            this.lblCurrentTurn.AutoSize = true;
            this.lblCurrentTurn.Location = new System.Drawing.Point(9, 222);
            this.lblCurrentTurn.Name = "lblCurrentTurn";
            this.lblCurrentTurn.Size = new System.Drawing.Size(69, 13);
            this.lblCurrentTurn.TabIndex = 18;
            this.lblCurrentTurn.Text = "Current Turn";
            // 
            // btnAudioOff
            // 
            this.btnAudioOff.Location = new System.Drawing.Point(211, 267);
            this.btnAudioOff.Name = "btnAudioOff";
            this.btnAudioOff.Size = new System.Drawing.Size(75, 23);
            this.btnAudioOff.TabIndex = 19;
            this.btnAudioOff.Text = "Audio Off";
            this.btnAudioOff.UseVisualStyleBackColor = true;
            // 
            // btnAudioOn
            // 
            this.btnAudioOn.Location = new System.Drawing.Point(134, 267);
            this.btnAudioOn.Name = "btnAudioOn";
            this.btnAudioOn.Size = new System.Drawing.Size(71, 23);
            this.btnAudioOn.TabIndex = 20;
            this.btnAudioOn.Text = "Audio On";
            this.btnAudioOn.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 294);
            this.Controls.Add(this.lblCurrentTurn);
            this.Controls.Add(this.lblName2);
            this.Controls.Add(this.lblName1);
            this.Controls.Add(this.radPlayerVsComputer);
            this.Controls.Add(this.radPlayerVsPlayer);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnAudioOn);
            this.Controls.Add(this.btnAudioOff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XO Game";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlBoard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer computerTimer;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RadioButton radPlayerVsPlayer;
        private System.Windows.Forms.RadioButton radPlayerVsComputer;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblCurrentTurn;
        private System.Windows.Forms.Button btnAudioOff;
        private System.Windows.Forms.Button btnAudioOn;
    }
}