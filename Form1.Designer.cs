
namespace JogoDado
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            gifDice = new PictureBox();
            player1 = new TextBox();
            player2 = new TextBox();
            winner = new Label();
            lauchDice = new Button();
            hackDice = new Button();
            scoreOnePlayer1 = new Label();
            scoreOnePlayer2 = new Label();
            scoreTwoPlayer1 = new Label();
            scoreThreePlayer1 = new Label();
            scoreTwoPlayer2 = new Label();
            scoreThreePlayer2 = new Label();
            selectHackDiceValue = new TextBox();
            errorForHackDice = new Label();
            timerDice = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)gifDice).BeginInit();
            SuspendLayout();
            // 
            // gifDice
            // 
            gifDice.Image = (Image)resources.GetObject("gifDice.Image");
            gifDice.Location = new Point(327, 180);
            gifDice.Name = "gifDice";
            gifDice.Size = new Size(77, 86);
            gifDice.TabIndex = 0;
            gifDice.TabStop = false;
            gifDice.Click += gifDice_Click;
            // 
            // player1
            // 
            player1.Location = new Point(82, 57);
            player1.Name = "player1";
            player1.Size = new Size(100, 23);
            player1.TabIndex = 1;
            player1.Text = "JOGADOR 1";
            player1.TextChanged += textBox1_TextChanged;
            // 
            // player2
            // 
            player2.Location = new Point(586, 57);
            player2.Name = "player2";
            player2.Size = new Size(100, 23);
            player2.TabIndex = 2;
            player2.Text = "JOGADOR 2";
            player2.TextChanged += textBox2_TextChanged;
            // 
            // winner
            // 
            winner.AutoSize = true;
            winner.Location = new Point(327, 65);
            winner.Name = "winner";
            winner.Size = new Size(53, 15);
            winner.TabIndex = 3;
            winner.Text = "x venceu";
            winner.Click += winner_Click;
            // 
            // lauchDice
            // 
            lauchDice.Location = new Point(238, 342);
            lauchDice.Name = "lauchDice";
            lauchDice.Size = new Size(75, 48);
            lauchDice.TabIndex = 4;
            lauchDice.Text = "Lançar dados";
            lauchDice.UseVisualStyleBackColor = true;
            lauchDice.Click += lauchDice_Click;
            // 
            // hackDice
            // 
            hackDice.Location = new Point(406, 342);
            hackDice.Name = "hackDice";
            hackDice.Size = new Size(75, 48);
            hackDice.TabIndex = 5;
            hackDice.Text = "Dado viciado";
            hackDice.UseVisualStyleBackColor = true;
            hackDice.Click += button2_Click;
            // 
            // scoreOnePlayer1
            // 
            scoreOnePlayer1.AutoSize = true;
            scoreOnePlayer1.Location = new Point(106, 102);
            scoreOnePlayer1.Name = "scoreOnePlayer1";
            scoreOnePlayer1.Size = new Size(38, 15);
            scoreOnePlayer1.TabIndex = 6;
            scoreOnePlayer1.Text = "label1";
            scoreOnePlayer1.Click += scoreOnePlayer1_Click;
            // 
            // scoreOnePlayer2
            // 
            scoreOnePlayer2.AutoSize = true;
            scoreOnePlayer2.Location = new Point(620, 102);
            scoreOnePlayer2.Name = "scoreOnePlayer2";
            scoreOnePlayer2.Size = new Size(38, 15);
            scoreOnePlayer2.TabIndex = 7;
            scoreOnePlayer2.Text = "label2";
            scoreOnePlayer2.Click += scoreOnePlayer2_Click;
            // 
            // scoreTwoPlayer1
            // 
            scoreTwoPlayer1.AutoSize = true;
            scoreTwoPlayer1.Location = new Point(106, 139);
            scoreTwoPlayer1.Name = "scoreTwoPlayer1";
            scoreTwoPlayer1.Size = new Size(38, 15);
            scoreTwoPlayer1.TabIndex = 8;
            scoreTwoPlayer1.Text = "label1";
            scoreTwoPlayer1.Click += scoreTwoPlayer1_click;
            // 
            // scoreThreePlayer1
            // 
            scoreThreePlayer1.AutoSize = true;
            scoreThreePlayer1.Location = new Point(106, 180);
            scoreThreePlayer1.Name = "scoreThreePlayer1";
            scoreThreePlayer1.Size = new Size(38, 15);
            scoreThreePlayer1.TabIndex = 9;
            scoreThreePlayer1.Text = "label1";
            scoreThreePlayer1.Click += scoreThreePlayer1_Click;
            // 
            // scoreTwoPlayer2
            // 
            scoreTwoPlayer2.AutoSize = true;
            scoreTwoPlayer2.Location = new Point(620, 139);
            scoreTwoPlayer2.Name = "scoreTwoPlayer2";
            scoreTwoPlayer2.Size = new Size(38, 15);
            scoreTwoPlayer2.TabIndex = 10;
            scoreTwoPlayer2.Text = "label2";
            scoreTwoPlayer2.Click += scoreTwoPlayer2_Click;
            // 
            // scoreThreePlayer2
            // 
            scoreThreePlayer2.AutoSize = true;
            scoreThreePlayer2.Location = new Point(620, 180);
            scoreThreePlayer2.Name = "scoreThreePlayer2";
            scoreThreePlayer2.Size = new Size(38, 15);
            scoreThreePlayer2.TabIndex = 11;
            scoreThreePlayer2.Text = "label2";
            scoreThreePlayer2.Click += scoreThreePlayer2_Click;
            // 
            // selectHackDiceValue
            // 
            selectHackDiceValue.Location = new Point(395, 396);
            selectHackDiceValue.Name = "selectHackDiceValue";
            selectHackDiceValue.Size = new Size(100, 23);
            selectHackDiceValue.TabIndex = 12;
            selectHackDiceValue.TextChanged += selectHackDiceValue_TextChanged;
            // 
            // errorForHackDice
            // 
            errorForHackDice.AutoSize = true;
            errorForHackDice.BorderStyle = BorderStyle.FixedSingle;
            errorForHackDice.ForeColor = Color.Red;
            errorForHackDice.Location = new Point(369, 315);
            errorForHackDice.Name = "errorForHackDice";
            errorForHackDice.Size = new Size(162, 17);
            errorForHackDice.TabIndex = 13;
            errorForHackDice.Text = "Valor inserido deve ser de 1-6";
            // 
            // timerDice
            // 
            timerDice.Interval = 3000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(errorForHackDice);
            Controls.Add(selectHackDiceValue);
            Controls.Add(scoreThreePlayer2);
            Controls.Add(scoreTwoPlayer2);
            Controls.Add(scoreThreePlayer1);
            Controls.Add(scoreTwoPlayer1);
            Controls.Add(scoreOnePlayer2);
            Controls.Add(scoreOnePlayer1);
            Controls.Add(hackDice);
            Controls.Add(lauchDice);
            Controls.Add(winner);
            Controls.Add(player2);
            Controls.Add(player1);
            Controls.Add(gifDice);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gifDice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void winner_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void scoreTwoPlayer1_click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox gifDice;
        private TextBox player1;
        private TextBox player2;
        private Label winner;
        private Button lauchDice;
        private Button hackDice;
        private Label scoreOnePlayer1;
        private Label scoreOnePlayer2;
        private Label scoreTwoPlayer1;
        private Label scoreThreePlayer1;
        private Label scoreTwoPlayer2;
        private Label scoreThreePlayer2;
        private TextBox selectHackDiceValue;
        private Label errorForHackDice;
        private System.Windows.Forms.Timer timerDice;
    }
}
