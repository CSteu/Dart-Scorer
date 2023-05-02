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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtCurrPlayer = new System.Windows.Forms.TextBox();
            this.txtCurrScore = new System.Windows.Forms.TextBox();
            this.btnEnterScore = new System.Windows.Forms.Button();
            this.txtStats = new System.Windows.Forms.TextBox();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.txtLastScore = new System.Windows.Forms.TextBox();
            this.txtNextPlayer = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtPlayer4 = new System.Windows.Forms.TextBox();
            this.txtPlayer3 = new System.Windows.Forms.TextBox();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.txtPlayer1Score = new System.Windows.Forms.TextBox();
            this.txtPlayer2Score = new System.Windows.Forms.TextBox();
            this.txtPlayer3Score = new System.Windows.Forms.TextBox();
            this.txtPlayer4Score = new System.Windows.Forms.TextBox();
            this.txtComputerScore = new System.Windows.Forms.TextBox();
            this.txtComputer = new System.Windows.Forms.TextBox();
            this.panelPlayer1 = new System.Windows.Forms.Panel();
            this.pbPlayer1 = new System.Windows.Forms.PictureBox();
            this.panelPlayer2 = new System.Windows.Forms.Panel();
            this.panelComputer = new System.Windows.Forms.Panel();
            this.pbComputer = new System.Windows.Forms.PictureBox();
            this.pbPlayer2 = new System.Windows.Forms.PictureBox();
            this.panelPlayer3 = new System.Windows.Forms.Panel();
            this.pbPlayer3 = new System.Windows.Forms.PictureBox();
            this.panelPlayer4 = new System.Windows.Forms.Panel();
            this.pbPlayer4 = new System.Windows.Forms.PictureBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.labelWinner = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtLegs = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelPlayer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).BeginInit();
            this.panelPlayer2.SuspendLayout();
            this.panelComputer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).BeginInit();
            this.panelPlayer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer3)).BeginInit();
            this.panelPlayer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer4)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(147)))));
            this.txtScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.txtScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtScore.Location = new System.Drawing.Point(251, 53);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(280, 121);
            this.txtScore.TabIndex = 3;
            this.txtScore.Text = "501";
            this.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCurrPlayer
            // 
            this.txtCurrPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(147)))));
            this.txtCurrPlayer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrPlayer.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.txtCurrPlayer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCurrPlayer.Location = new System.Drawing.Point(251, 1);
            this.txtCurrPlayer.Name = "txtCurrPlayer";
            this.txtCurrPlayer.ReadOnly = true;
            this.txtCurrPlayer.Size = new System.Drawing.Size(280, 45);
            this.txtCurrPlayer.TabIndex = 1;
            this.txtCurrPlayer.Text = "Player 1";
            this.txtCurrPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCurrScore
            // 
            this.txtCurrScore.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrScore.Location = new System.Drawing.Point(251, 207);
            this.txtCurrScore.Name = "txtCurrScore";
            this.txtCurrScore.Size = new System.Drawing.Size(191, 43);
            this.txtCurrScore.TabIndex = 0;
            this.txtCurrScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCurrScore.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCurrScore_KeyDown);
            // 
            // btnEnterScore
            // 
            this.btnEnterScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.btnEnterScore.FlatAppearance.BorderSize = 0;
            this.btnEnterScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterScore.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnEnterScore.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEnterScore.Location = new System.Drawing.Point(448, 207);
            this.btnEnterScore.Name = "btnEnterScore";
            this.btnEnterScore.Size = new System.Drawing.Size(83, 43);
            this.btnEnterScore.TabIndex = 4;
            this.btnEnterScore.Text = "ENTER";
            this.btnEnterScore.UseVisualStyleBackColor = false;
            this.btnEnterScore.Click += new System.EventHandler(this.btnEnterScore_Click);
            // 
            // txtStats
            // 
            this.txtStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.txtStats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStats.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStats.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtStats.Location = new System.Drawing.Point(537, 1);
            this.txtStats.Multiline = true;
            this.txtStats.Name = "txtStats";
            this.txtStats.ReadOnly = true;
            this.txtStats.Size = new System.Drawing.Size(259, 267);
            this.txtStats.TabIndex = 5;
            this.txtStats.Text = "Three Dart Average:\r\n0.00\r\nFirst Nine Average:\r\n0.00\r\nLast Score:\r\n0\r\nDarts Throw" +
    "n:\r\n0";
            this.txtStats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.txtPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayer1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPlayer1.Location = new System.Drawing.Point(0, 0);
            this.txtPlayer1.Multiline = true;
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.ReadOnly = true;
            this.txtPlayer1.Size = new System.Drawing.Size(242, 63);
            this.txtPlayer1.TabIndex = 7;
            this.txtPlayer1.Text = "player 1: 501\r\nAverage: 0\r\n";
            this.txtPlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLastScore
            // 
            this.txtLastScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(147)))));
            this.txtLastScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLastScore.Location = new System.Drawing.Point(251, 180);
            this.txtLastScore.Name = "txtLastScore";
            this.txtLastScore.ReadOnly = true;
            this.txtLastScore.Size = new System.Drawing.Size(279, 22);
            this.txtLastScore.TabIndex = 9;
            this.txtLastScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNextPlayer
            // 
            this.txtNextPlayer.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNextPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(74)))), ((int)(((byte)(68)))));
            this.txtNextPlayer.Location = new System.Drawing.Point(49, 43);
            this.txtNextPlayer.Multiline = true;
            this.txtNextPlayer.Name = "txtNextPlayer";
            this.txtNextPlayer.Size = new System.Drawing.Size(706, 159);
            this.txtNextPlayer.TabIndex = 11;
            this.txtNextPlayer.Text = "Next Player";
            this.txtNextPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 5);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 5);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 384);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(830, 5);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 379);
            this.panel4.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(825, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 379);
            this.panel5.TabIndex = 16;
            // 
            // txtPlayer4
            // 
            this.txtPlayer4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.txtPlayer4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayer4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPlayer4.Location = new System.Drawing.Point(0, 0);
            this.txtPlayer4.Multiline = true;
            this.txtPlayer4.Name = "txtPlayer4";
            this.txtPlayer4.ReadOnly = true;
            this.txtPlayer4.Size = new System.Drawing.Size(242, 63);
            this.txtPlayer4.TabIndex = 18;
            this.txtPlayer4.Text = "player 1: 501\r\nAverage: 0\r\n";
            this.txtPlayer4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPlayer3
            // 
            this.txtPlayer3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.txtPlayer3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayer3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPlayer3.Location = new System.Drawing.Point(0, 0);
            this.txtPlayer3.Multiline = true;
            this.txtPlayer3.Name = "txtPlayer3";
            this.txtPlayer3.ReadOnly = true;
            this.txtPlayer3.Size = new System.Drawing.Size(242, 63);
            this.txtPlayer3.TabIndex = 20;
            this.txtPlayer3.Text = "player 1: 501\r\nAverage: 0\r\n";
            this.txtPlayer3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.txtPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayer2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPlayer2.Location = new System.Drawing.Point(0, 0);
            this.txtPlayer2.Multiline = true;
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.ReadOnly = true;
            this.txtPlayer2.Size = new System.Drawing.Size(242, 63);
            this.txtPlayer2.TabIndex = 22;
            this.txtPlayer2.Text = "player 1: 501\r\nAverage: 0\r\n";
            this.txtPlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPlayer1Score
            // 
            this.txtPlayer1Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.txtPlayer1Score.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayer1Score.Font = new System.Drawing.Font("Arial", 40F);
            this.txtPlayer1Score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPlayer1Score.Location = new System.Drawing.Point(194, 0);
            this.txtPlayer1Score.Multiline = true;
            this.txtPlayer1Score.Name = "txtPlayer1Score";
            this.txtPlayer1Score.ReadOnly = true;
            this.txtPlayer1Score.Size = new System.Drawing.Size(48, 63);
            this.txtPlayer1Score.TabIndex = 25;
            this.txtPlayer1Score.Text = "0";
            this.txtPlayer1Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPlayer2Score
            // 
            this.txtPlayer2Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.txtPlayer2Score.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayer2Score.Font = new System.Drawing.Font("Arial", 40F);
            this.txtPlayer2Score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPlayer2Score.Location = new System.Drawing.Point(194, 0);
            this.txtPlayer2Score.Multiline = true;
            this.txtPlayer2Score.Name = "txtPlayer2Score";
            this.txtPlayer2Score.ReadOnly = true;
            this.txtPlayer2Score.Size = new System.Drawing.Size(48, 63);
            this.txtPlayer2Score.TabIndex = 26;
            this.txtPlayer2Score.Text = "0";
            this.txtPlayer2Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPlayer3Score
            // 
            this.txtPlayer3Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.txtPlayer3Score.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayer3Score.Font = new System.Drawing.Font("Arial", 40F);
            this.txtPlayer3Score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPlayer3Score.Location = new System.Drawing.Point(194, 0);
            this.txtPlayer3Score.Multiline = true;
            this.txtPlayer3Score.Name = "txtPlayer3Score";
            this.txtPlayer3Score.ReadOnly = true;
            this.txtPlayer3Score.Size = new System.Drawing.Size(48, 63);
            this.txtPlayer3Score.TabIndex = 27;
            this.txtPlayer3Score.Text = "0";
            this.txtPlayer3Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPlayer4Score
            // 
            this.txtPlayer4Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.txtPlayer4Score.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayer4Score.Font = new System.Drawing.Font("Arial", 40F);
            this.txtPlayer4Score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPlayer4Score.Location = new System.Drawing.Point(194, 0);
            this.txtPlayer4Score.Multiline = true;
            this.txtPlayer4Score.Name = "txtPlayer4Score";
            this.txtPlayer4Score.ReadOnly = true;
            this.txtPlayer4Score.Size = new System.Drawing.Size(48, 63);
            this.txtPlayer4Score.TabIndex = 28;
            this.txtPlayer4Score.Text = "0";
            this.txtPlayer4Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtComputerScore
            // 
            this.txtComputerScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.txtComputerScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComputerScore.Font = new System.Drawing.Font("Arial", 40F);
            this.txtComputerScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtComputerScore.Location = new System.Drawing.Point(194, 0);
            this.txtComputerScore.Multiline = true;
            this.txtComputerScore.Name = "txtComputerScore";
            this.txtComputerScore.ReadOnly = true;
            this.txtComputerScore.Size = new System.Drawing.Size(48, 63);
            this.txtComputerScore.TabIndex = 31;
            this.txtComputerScore.Text = "0";
            this.txtComputerScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtComputerScore.TextChanged += new System.EventHandler(this.txtComputerScore_TextChanged);
            // 
            // txtComputer
            // 
            this.txtComputer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.txtComputer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComputer.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComputer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtComputer.Location = new System.Drawing.Point(0, 0);
            this.txtComputer.Multiline = true;
            this.txtComputer.Name = "txtComputer";
            this.txtComputer.ReadOnly = true;
            this.txtComputer.Size = new System.Drawing.Size(242, 63);
            this.txtComputer.TabIndex = 29;
            this.txtComputer.Text = "player 1: 501\r\nAverage: 0\r\n";
            this.txtComputer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtComputer.TextChanged += new System.EventHandler(this.txtComputer_TextChanged);
            // 
            // panelPlayer1
            // 
            this.panelPlayer1.Controls.Add(this.pbPlayer1);
            this.panelPlayer1.Controls.Add(this.txtPlayer1Score);
            this.panelPlayer1.Controls.Add(this.txtPlayer1);
            this.panelPlayer1.Location = new System.Drawing.Point(3, 1);
            this.panelPlayer1.Name = "panelPlayer1";
            this.panelPlayer1.Size = new System.Drawing.Size(242, 63);
            this.panelPlayer1.TabIndex = 34;
            // 
            // pbPlayer1
            // 
            this.pbPlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.pbPlayer1.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayer1.Image")));
            this.pbPlayer1.Location = new System.Drawing.Point(0, 0);
            this.pbPlayer1.Name = "pbPlayer1";
            this.pbPlayer1.Size = new System.Drawing.Size(49, 50);
            this.pbPlayer1.TabIndex = 17;
            this.pbPlayer1.TabStop = false;
            // 
            // panelPlayer2
            // 
            this.panelPlayer2.Controls.Add(this.panelComputer);
            this.panelPlayer2.Controls.Add(this.pbPlayer2);
            this.panelPlayer2.Controls.Add(this.txtPlayer2Score);
            this.panelPlayer2.Controls.Add(this.txtPlayer2);
            this.panelPlayer2.Location = new System.Drawing.Point(4, 70);
            this.panelPlayer2.Name = "panelPlayer2";
            this.panelPlayer2.Size = new System.Drawing.Size(242, 63);
            this.panelPlayer2.TabIndex = 35;
            // 
            // panelComputer
            // 
            this.panelComputer.Controls.Add(this.txtComputerScore);
            this.panelComputer.Controls.Add(this.pbComputer);
            this.panelComputer.Controls.Add(this.txtComputer);
            this.panelComputer.Location = new System.Drawing.Point(0, 0);
            this.panelComputer.Name = "panelComputer";
            this.panelComputer.Size = new System.Drawing.Size(242, 63);
            this.panelComputer.TabIndex = 37;
            // 
            // pbComputer
            // 
            this.pbComputer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.pbComputer.Image = ((System.Drawing.Image)(resources.GetObject("pbComputer.Image")));
            this.pbComputer.Location = new System.Drawing.Point(0, 0);
            this.pbComputer.Name = "pbComputer";
            this.pbComputer.Size = new System.Drawing.Size(49, 50);
            this.pbComputer.TabIndex = 30;
            this.pbComputer.TabStop = false;
            this.pbComputer.Click += new System.EventHandler(this.pbComputer_Click);
            // 
            // pbPlayer2
            // 
            this.pbPlayer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.pbPlayer2.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayer2.Image")));
            this.pbPlayer2.Location = new System.Drawing.Point(0, 0);
            this.pbPlayer2.Name = "pbPlayer2";
            this.pbPlayer2.Size = new System.Drawing.Size(49, 50);
            this.pbPlayer2.TabIndex = 23;
            this.pbPlayer2.TabStop = false;
            // 
            // panelPlayer3
            // 
            this.panelPlayer3.Controls.Add(this.pbPlayer3);
            this.panelPlayer3.Controls.Add(this.txtPlayer3Score);
            this.panelPlayer3.Controls.Add(this.txtPlayer3);
            this.panelPlayer3.Location = new System.Drawing.Point(4, 139);
            this.panelPlayer3.Name = "panelPlayer3";
            this.panelPlayer3.Size = new System.Drawing.Size(242, 63);
            this.panelPlayer3.TabIndex = 36;
            // 
            // pbPlayer3
            // 
            this.pbPlayer3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.pbPlayer3.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayer3.Image")));
            this.pbPlayer3.Location = new System.Drawing.Point(0, 0);
            this.pbPlayer3.Name = "pbPlayer3";
            this.pbPlayer3.Size = new System.Drawing.Size(49, 50);
            this.pbPlayer3.TabIndex = 21;
            this.pbPlayer3.TabStop = false;
            // 
            // panelPlayer4
            // 
            this.panelPlayer4.Controls.Add(this.pbPlayer4);
            this.panelPlayer4.Controls.Add(this.txtPlayer4Score);
            this.panelPlayer4.Controls.Add(this.txtPlayer4);
            this.panelPlayer4.Location = new System.Drawing.Point(4, 208);
            this.panelPlayer4.Name = "panelPlayer4";
            this.panelPlayer4.Size = new System.Drawing.Size(242, 63);
            this.panelPlayer4.TabIndex = 36;
            // 
            // pbPlayer4
            // 
            this.pbPlayer4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.pbPlayer4.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayer4.Image")));
            this.pbPlayer4.Location = new System.Drawing.Point(0, 0);
            this.pbPlayer4.Name = "pbPlayer4";
            this.pbPlayer4.Size = new System.Drawing.Size(49, 50);
            this.pbPlayer4.TabIndex = 19;
            this.pbPlayer4.TabStop = false;
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnContinue.ForeColor = System.Drawing.SystemColors.Control;
            this.btnContinue.Location = new System.Drawing.Point(343, 250);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(108, 46);
            this.btnContinue.TabIndex = 38;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click_1);
            // 
            // labelWinner
            // 
            this.labelWinner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelWinner.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWinner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.labelWinner.Location = new System.Drawing.Point(177, 24);
            this.labelWinner.Multiline = true;
            this.labelWinner.Name = "labelWinner";
            this.labelWinner.Size = new System.Drawing.Size(439, 221);
            this.labelWinner.TabIndex = 39;
            this.labelWinner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.labelWinner);
            this.panel6.Controls.Add(this.txtNextPlayer);
            this.panel6.Controls.Add(this.btnContinue);
            this.panel6.Controls.Add(this.panelPlayer3);
            this.panel6.Controls.Add(this.panelPlayer2);
            this.panel6.Controls.Add(this.panelPlayer4);
            this.panel6.Controls.Add(this.panelPlayer1);
            this.panel6.Controls.Add(this.txtLastScore);
            this.panel6.Controls.Add(this.txtStats);
            this.panel6.Controls.Add(this.btnEnterScore);
            this.panel6.Controls.Add(this.txtCurrScore);
            this.panel6.Controls.Add(this.txtCurrPlayer);
            this.panel6.Controls.Add(this.txtScore);
            this.panel6.Location = new System.Drawing.Point(12, 79);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(807, 296);
            this.panel6.TabIndex = 38;
            // 
            // txtLegs
            // 
            this.txtLegs.BackColor = System.Drawing.SystemColors.Control;
            this.txtLegs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLegs.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLegs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.txtLegs.Location = new System.Drawing.Point(256, 20);
            this.txtLegs.Multiline = true;
            this.txtLegs.Name = "txtLegs";
            this.txtLegs.Size = new System.Drawing.Size(301, 46);
            this.txtLegs.TabIndex = 39;
            this.txtLegs.Text = "Best of 1 Legs";
            this.txtLegs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(646, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "<- RETURN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLegs);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.panel1.ResumeLayout(false);
            this.panelPlayer1.ResumeLayout(false);
            this.panelPlayer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).EndInit();
            this.panelPlayer2.ResumeLayout(false);
            this.panelPlayer2.PerformLayout();
            this.panelComputer.ResumeLayout(false);
            this.panelComputer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).EndInit();
            this.panelPlayer3.ResumeLayout(false);
            this.panelPlayer3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer3)).EndInit();
            this.panelPlayer4.ResumeLayout(false);
            this.panelPlayer4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer4)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScore;
        public System.Windows.Forms.TextBox txtCurrPlayer;
        private System.Windows.Forms.TextBox txtCurrScore;
        private System.Windows.Forms.Button btnEnterScore;
        private System.Windows.Forms.TextBox txtStats;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.TextBox txtLastScore;
        private System.Windows.Forms.TextBox txtNextPlayer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pbPlayer1;
        private System.Windows.Forms.PictureBox pbPlayer4;
        private System.Windows.Forms.TextBox txtPlayer4;
        private System.Windows.Forms.PictureBox pbPlayer3;
        private System.Windows.Forms.TextBox txtPlayer3;
        private System.Windows.Forms.PictureBox pbPlayer2;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPlayer1Score;
        private System.Windows.Forms.TextBox txtPlayer2Score;
        private System.Windows.Forms.TextBox txtPlayer3Score;
        private System.Windows.Forms.TextBox txtPlayer4Score;
        private System.Windows.Forms.TextBox txtComputerScore;
        private System.Windows.Forms.PictureBox pbComputer;
        private System.Windows.Forms.TextBox txtComputer;
        private System.Windows.Forms.Panel panelPlayer1;
        private System.Windows.Forms.Panel panelPlayer2;
        private System.Windows.Forms.Panel panelComputer;
        private System.Windows.Forms.Panel panelPlayer3;
        private System.Windows.Forms.Panel panelPlayer4;
        private System.Windows.Forms.TextBox labelWinner;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtLegs;
        private System.Windows.Forms.Label label1;
    }
}