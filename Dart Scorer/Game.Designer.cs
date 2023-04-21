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
            this.txtPlayerList = new System.Windows.Forms.RichTextBox();
            this.txtCurrScore = new System.Windows.Forms.TextBox();
            this.btnEnterScore = new System.Windows.Forms.Button();
            this.txtStats = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.txtScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtScore.Location = new System.Drawing.Point(258, 104);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(181, 128);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "501";
            this.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCurrPlayer
            // 
            this.txtCurrPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtCurrPlayer.Location = new System.Drawing.Point(258, 45);
            this.txtCurrPlayer.Name = "txtCurrPlayer";
            this.txtCurrPlayer.Size = new System.Drawing.Size(181, 53);
            this.txtCurrPlayer.TabIndex = 1;
            this.txtCurrPlayer.Text = "Player 1";
            this.txtCurrPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPlayerList
            // 
            this.txtPlayerList.Location = new System.Drawing.Point(27, 45);
            this.txtPlayerList.Name = "txtPlayerList";
            this.txtPlayerList.Size = new System.Drawing.Size(138, 369);
            this.txtPlayerList.TabIndex = 2;
            this.txtPlayerList.Text = "Other players";
            // 
            // txtCurrScore
            // 
            this.txtCurrScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtCurrScore.Location = new System.Drawing.Point(258, 257);
            this.txtCurrScore.Name = "txtCurrScore";
            this.txtCurrScore.Size = new System.Drawing.Size(100, 38);
            this.txtCurrScore.TabIndex = 3;
            // 
            // btnEnterScore
            // 
            this.btnEnterScore.Location = new System.Drawing.Point(364, 270);
            this.btnEnterScore.Name = "btnEnterScore";
            this.btnEnterScore.Size = new System.Drawing.Size(75, 23);
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
            this.txtStats.Size = new System.Drawing.Size(209, 369);
            this.txtStats.TabIndex = 5;
            this.txtStats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(258, 345);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtStats);
            this.Controls.Add(this.btnEnterScore);
            this.Controls.Add(this.txtCurrScore);
            this.Controls.Add(this.txtPlayerList);
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
        private System.Windows.Forms.RichTextBox txtPlayerList;
        private System.Windows.Forms.TextBox txtCurrScore;
        private System.Windows.Forms.Button btnEnterScore;
        private System.Windows.Forms.TextBox txtStats;
        private System.Windows.Forms.TextBox textBox1;
    }
}