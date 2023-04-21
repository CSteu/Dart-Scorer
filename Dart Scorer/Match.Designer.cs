namespace Dart_Scorer
{
    partial class Match
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
            this.label1 = new System.Windows.Forms.Label();
            this.computerCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.playerUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnStartMatch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.txtPlayer3 = new System.Windows.Forms.TextBox();
            this.txtPlayer4 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb701 = new System.Windows.Forms.RadioButton();
            this.rb501 = new System.Windows.Forms.RadioButton();
            this.rb301 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb5leg = new System.Windows.Forms.RadioButton();
            this.rb3leg = new System.Windows.Forms.RadioButton();
            this.rb1leg = new System.Windows.Forms.RadioButton();
            this.txtDartbot = new System.Windows.Forms.TextBox();
            this.upDownSkillLevel = new System.Windows.Forms.NumericUpDown();
            this.dartbotLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSkillLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "VS. Computer";
            // 
            // computerCheck
            // 
            this.computerCheck.AutoSize = true;
            this.computerCheck.Location = new System.Drawing.Point(435, 146);
            this.computerCheck.Name = "computerCheck";
            this.computerCheck.Size = new System.Drawing.Size(22, 21);
            this.computerCheck.TabIndex = 2;
            this.computerCheck.UseVisualStyleBackColor = true;
            this.computerCheck.CheckedChanged += new System.EventHandler(this.computerCheck_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(92, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Players:";
            // 
            // playerUpDown
            // 
            this.playerUpDown.Location = new System.Drawing.Point(234, 145);
            this.playerUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.playerUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.playerUpDown.Name = "playerUpDown";
            this.playerUpDown.Size = new System.Drawing.Size(64, 26);
            this.playerUpDown.TabIndex = 6;
            this.playerUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.playerUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.playerUpDown.ValueChanged += new System.EventHandler(this.playerUpDown_ValueChanged);
            // 
            // btnStartMatch
            // 
            this.btnStartMatch.Location = new System.Drawing.Point(92, 457);
            this.btnStartMatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStartMatch.Name = "btnStartMatch";
            this.btnStartMatch.Size = new System.Drawing.Size(862, 35);
            this.btnStartMatch.TabIndex = 9;
            this.btnStartMatch.Text = "START GAME";
            this.btnStartMatch.UseVisualStyleBackColor = true;
            this.btnStartMatch.Click += new System.EventHandler(this.btnStartMatch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(382, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 46);
            this.label3.TabIndex = 10;
            this.label3.Text = "Match Setup";
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtPlayer1.Location = new System.Drawing.Point(92, 183);
            this.txtPlayer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(364, 48);
            this.txtPlayer1.TabIndex = 16;
            this.txtPlayer1.Text = "Player 1";
            this.txtPlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtPlayer2.Location = new System.Drawing.Point(92, 246);
            this.txtPlayer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(364, 48);
            this.txtPlayer2.TabIndex = 17;
            this.txtPlayer2.Text = "Player 2";
            this.txtPlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPlayer3
            // 
            this.txtPlayer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtPlayer3.Location = new System.Drawing.Point(92, 309);
            this.txtPlayer3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPlayer3.Name = "txtPlayer3";
            this.txtPlayer3.Size = new System.Drawing.Size(364, 48);
            this.txtPlayer3.TabIndex = 18;
            this.txtPlayer3.Text = "Player 3";
            this.txtPlayer3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPlayer4
            // 
            this.txtPlayer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtPlayer4.Location = new System.Drawing.Point(92, 372);
            this.txtPlayer4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPlayer4.Name = "txtPlayer4";
            this.txtPlayer4.Size = new System.Drawing.Size(364, 48);
            this.txtPlayer4.TabIndex = 19;
            this.txtPlayer4.Text = "Player 4";
            this.txtPlayer4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb701);
            this.groupBox1.Controls.Add(this.rb501);
            this.groupBox1.Controls.Add(this.rb301);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox1.Location = new System.Drawing.Point(524, 183);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(430, 111);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Start Score";
            // 
            // rb701
            // 
            this.rb701.AutoSize = true;
            this.rb701.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rb701.Location = new System.Drawing.Point(296, 38);
            this.rb701.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb701.Name = "rb701";
            this.rb701.Size = new System.Drawing.Size(102, 44);
            this.rb701.TabIndex = 2;
            this.rb701.Text = "701";
            this.rb701.UseVisualStyleBackColor = true;
            // 
            // rb501
            // 
            this.rb501.AutoSize = true;
            this.rb501.Checked = true;
            this.rb501.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rb501.Location = new System.Drawing.Point(168, 38);
            this.rb501.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb501.Name = "rb501";
            this.rb501.Size = new System.Drawing.Size(102, 44);
            this.rb501.TabIndex = 1;
            this.rb501.TabStop = true;
            this.rb501.Text = "501";
            this.rb501.UseVisualStyleBackColor = true;
            // 
            // rb301
            // 
            this.rb301.AutoSize = true;
            this.rb301.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rb301.Location = new System.Drawing.Point(33, 37);
            this.rb301.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb301.Name = "rb301";
            this.rb301.Size = new System.Drawing.Size(102, 44);
            this.rb301.TabIndex = 0;
            this.rb301.Text = "301";
            this.rb301.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb5leg);
            this.groupBox2.Controls.Add(this.rb3leg);
            this.groupBox2.Controls.Add(this.rb1leg);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox2.Location = new System.Drawing.Point(524, 309);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(430, 117);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Best Of";
            // 
            // rb5leg
            // 
            this.rb5leg.AutoSize = true;
            this.rb5leg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rb5leg.Location = new System.Drawing.Point(296, 45);
            this.rb5leg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb5leg.Name = "rb5leg";
            this.rb5leg.Size = new System.Drawing.Size(124, 36);
            this.rb5leg.TabIndex = 2;
            this.rb5leg.Text = "5 Legs";
            this.rb5leg.UseVisualStyleBackColor = true;
            // 
            // rb3leg
            // 
            this.rb3leg.AutoSize = true;
            this.rb3leg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rb3leg.Location = new System.Drawing.Point(160, 45);
            this.rb3leg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb3leg.Name = "rb3leg";
            this.rb3leg.Size = new System.Drawing.Size(124, 36);
            this.rb3leg.TabIndex = 1;
            this.rb3leg.Text = "3 Legs";
            this.rb3leg.UseVisualStyleBackColor = true;
            // 
            // rb1leg
            // 
            this.rb1leg.AutoSize = true;
            this.rb1leg.Checked = true;
            this.rb1leg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rb1leg.Location = new System.Drawing.Point(33, 45);
            this.rb1leg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb1leg.Name = "rb1leg";
            this.rb1leg.Size = new System.Drawing.Size(110, 36);
            this.rb1leg.TabIndex = 0;
            this.rb1leg.TabStop = true;
            this.rb1leg.Text = "1 Leg";
            this.rb1leg.UseVisualStyleBackColor = true;
            // 
            // txtDartbot
            // 
            this.txtDartbot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtDartbot.Location = new System.Drawing.Point(93, 246);
            this.txtDartbot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDartbot.Name = "txtDartbot";
            this.txtDartbot.Size = new System.Drawing.Size(293, 48);
            this.txtDartbot.TabIndex = 22;
            this.txtDartbot.Text = "Dartbot";
            this.txtDartbot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // upDownSkillLevel
            // 
            this.upDownSkillLevel.Location = new System.Drawing.Point(393, 268);
            this.upDownSkillLevel.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.upDownSkillLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownSkillLevel.Name = "upDownSkillLevel";
            this.upDownSkillLevel.Size = new System.Drawing.Size(64, 26);
            this.upDownSkillLevel.TabIndex = 23;
            this.upDownSkillLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.upDownSkillLevel.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // dartbotLabel
            // 
            this.dartbotLabel.AutoSize = true;
            this.dartbotLabel.Location = new System.Drawing.Point(383, 246);
            this.dartbotLabel.Name = "dartbotLabel";
            this.dartbotLabel.Size = new System.Drawing.Size(73, 20);
            this.dartbotLabel.TabIndex = 24;
            this.dartbotLabel.Text = "Difficulty:";
            // 
            // Match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 577);
            this.Controls.Add(this.upDownSkillLevel);
            this.Controls.Add(this.dartbotLabel);
            this.Controls.Add(this.txtDartbot);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPlayer4);
            this.Controls.Add(this.txtPlayer3);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStartMatch);
            this.Controls.Add(this.playerUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.computerCheck);
            this.Controls.Add(this.label1);
            this.Name = "Match";
            this.Text = "Match";
            ((System.ComponentModel.ISupportInitialize)(this.playerUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSkillLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox computerCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown playerUpDown;
        private System.Windows.Forms.Button btnStartMatch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.TextBox txtPlayer3;
        private System.Windows.Forms.TextBox txtPlayer4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb701;
        private System.Windows.Forms.RadioButton rb501;
        private System.Windows.Forms.RadioButton rb301;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb5leg;
        private System.Windows.Forms.RadioButton rb3leg;
        private System.Windows.Forms.RadioButton rb1leg;
        private System.Windows.Forms.TextBox txtDartbot;
        private System.Windows.Forms.NumericUpDown upDownSkillLevel;
        private System.Windows.Forms.Label dartbotLabel;
    }
}