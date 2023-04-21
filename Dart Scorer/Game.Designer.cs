namespace Dart_Scorer
{
    partial class Game
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
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtCurrPlayer = new System.Windows.Forms.TextBox();
            this.txtCurrScore = new System.Windows.Forms.TextBox();
            this.btnEnterScore = new System.Windows.Forms.Button();
            this.txtStats = new System.Windows.Forms.TextBox();
            this.txtPlayerList = new System.Windows.Forms.TextBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.txtLastScore = new System.Windows.Forms.TextBox();
            this.txtCmp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.txtScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtScore.Location = new System.Drawing.Point(220, 104);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(265, 128);
            this.txtScore.TabIndex = 3;
            this.txtScore.Text = "501";
            this.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCurrPlayer
            // 
            this.txtCurrPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtCurrPlayer.Location = new System.Drawing.Point(220, 45);
            this.txtCurrPlayer.Name = "txtCurrPlayer";
            this.txtCurrPlayer.ReadOnly = true;
            this.txtCurrPlayer.Size = new System.Drawing.Size(265, 53);
            this.txtCurrPlayer.TabIndex = 1;
            this.txtCurrPlayer.Text = "Player 1";
            this.txtCurrPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCurrScore
            // 
            this.txtCurrScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtCurrScore.Location = new System.Drawing.Point(220, 278);
            this.txtCurrScore.Name = "txtCurrScore";
            this.txtCurrScore.Size = new System.Drawing.Size(176, 38);
            this.txtCurrScore.TabIndex = 0;
            this.txtCurrScore.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCurrScore_KeyDown);
            // 
            // btnEnterScore
            // 
            this.btnEnterScore.Location = new System.Drawing.Point(402, 278);
            this.btnEnterScore.Name = "btnEnterScore";
            this.btnEnterScore.Size = new System.Drawing.Size(83, 38);
            this.btnEnterScore.TabIndex = 4;
            this.btnEnterScore.Text = "ENTER";
            this.btnEnterScore.UseVisualStyleBackColor = true;
            this.btnEnterScore.Click += new System.EventHandler(this.btnEnterScore_Click);
            // 
            // txtStats
            // 
            this.txtStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtStats.Location = new System.Drawing.Point(491, 45);
            this.txtStats.Multiline = true;
            this.txtStats.Name = "txtStats";
            this.txtStats.ReadOnly = true;
            this.txtStats.Size = new System.Drawing.Size(209, 292);
            this.txtStats.TabIndex = 5;
            this.txtStats.Text = "Three Dart Average:\r\n0.00\r\nFirst Nine Average:\r\n0.00\r\nLast Score:\r\n0\r\nDarts Throw" +
    "n:\r\n0";
            this.txtStats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPlayerList
            // 
            this.txtPlayerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPlayerList.Location = new System.Drawing.Point(27, 45);
            this.txtPlayerList.Multiline = true;
            this.txtPlayerList.Name = "txtPlayerList";
            this.txtPlayerList.ReadOnly = true;
            this.txtPlayerList.Size = new System.Drawing.Size(187, 292);
            this.txtPlayerList.TabIndex = 7;
            this.txtPlayerList.Text = "player 1: 501\r\nAverage: 0\r\nplayer 2: 501\r\nAverage: 0\r\nplayer 3: 501\r\nAverage: 0\r\n" +
    "player 4: 501\r\nAverage: 0\r\n";
            this.txtPlayerList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(27, 12);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 8;
            this.btnRestart.Text = "Restart Game";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // txtLastScore
            // 
            this.txtLastScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLastScore.Location = new System.Drawing.Point(220, 238);
            this.txtLastScore.Name = "txtLastScore";
            this.txtLastScore.ReadOnly = true;
            this.txtLastScore.Size = new System.Drawing.Size(264, 26);
            this.txtLastScore.TabIndex = 9;
            this.txtLastScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCmp
            // 
            this.txtCmp.Location = new System.Drawing.Point(220, 323);
            this.txtCmp.Name = "txtCmp";
            this.txtCmp.Size = new System.Drawing.Size(176, 20);
            this.txtCmp.TabIndex = 10;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 366);
            this.Controls.Add(this.txtCmp);
            this.Controls.Add(this.txtLastScore);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.txtPlayerList);
            this.Controls.Add(this.txtStats);
            this.Controls.Add(this.btnEnterScore);
            this.Controls.Add(this.txtCurrScore);
            this.Controls.Add(this.txtCurrPlayer);
            this.Controls.Add(this.txtScore);
            this.Name = "Game";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScore;
        public System.Windows.Forms.TextBox txtCurrPlayer;
        private System.Windows.Forms.TextBox txtCurrScore;
        private System.Windows.Forms.Button btnEnterScore;
        private System.Windows.Forms.TextBox txtStats;
        private System.Windows.Forms.TextBox txtPlayerList;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.TextBox txtLastScore;
        private System.Windows.Forms.TextBox txtCmp;
    }
}