namespace JogoDado
{
    public partial class Form1 : Form
    {
        private int round = 0;
        private int winnersForPlayer1 = 0;
        private int winnersForPlayer2 = 0;
        private bool hackDiceActivate = false;
        private int valueHackDice = 0;
        private Random random = new Random();

        private int valor1;
        private int valor2;

        public Form1()
        {
            InitializeComponent();
            scoreOnePlayer1.Visible = false;
            scoreTwoPlayer1.Visible = false;
            scoreThreePlayer1.Visible = false;

            scoreOnePlayer2.Visible = false;
            scoreTwoPlayer2.Visible = false;
            scoreThreePlayer2.Visible = false;

            winner.Visible = false;
            errorForHackDice.Visible = false;
            gifDice.Visible = false;
            timerDice.Tick += timerDice_Tick;
            timerDice.Enabled = false;
            timerDice.Interval = 3000;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void scoreOnePlayer1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // hackDice
        {
            if (round == 0)
            {
                int valor;
                if (int.TryParse(selectHackDiceValue.Text, out valor) && valor >= 1 && valor <= 6)
                {
                    hackDiceActivate = true;
                    valueHackDice = valor;
                    errorForHackDice.Visible = false;
                    MessageBox.Show("Dado viciado configurado para sempre cair em " + valor);
                }
                else
                {
                    errorForHackDice.Text = "Digite um valor entre 1 e 6!";
                    errorForHackDice.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("O dado viciado só pode ser configurado antes da primeira jogada!");
            }

        }

        private void scoreOnePlayer1_Click_1(object sender, EventArgs e)
        {

        }

        private void gifDice_Click(object sender, EventArgs e)
        {

        }

 

        private void scoreOnePlayer2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void scoreTwoPlayer2_Click(object sender, EventArgs e)
        {

        }

        private void scoreThreePlayer1_Click(object sender, EventArgs e)
        {

        }

        private void scoreThreePlayer2_Click(object sender, EventArgs e)
        {

        }

        private void lauchDice_Click(object sender, EventArgs e) // lauchDice
        {
            if (round >= 3)
            {
                MessageBox.Show("O jogo já acabou! Reinicie para jogar novamente.");
                return;
            }

            player1.Enabled = false;
            player2.Enabled = false;

            round++;

            valor1 = lauchDiceMethod();
            valor2 = lauchDiceMethod();

            gifDice.Visible = true;
            gifDice.BringToFront();
            timerDice.Start();

            
        }

        private int lauchDiceMethod() // metodo de lançar dado
        {
            if (hackDiceActivate)
                return valueHackDice;
            else
                return random.Next(1, 7);
        }

        private void timerDice_Tick(object sender, EventArgs e)
        {
            timerDice.Stop();
            gifDice.Visible = false;

            if (round == 1)
            {
                scoreOnePlayer1.Text = valor1.ToString();
                scoreOnePlayer1.Visible = true;

                scoreOnePlayer2.Text = valor2.ToString();
                scoreOnePlayer2.Visible = true;
            }
            else if (round == 2)
            {
                scoreTwoPlayer1.Text = valor1.ToString();
                scoreTwoPlayer1.Visible = true;

                scoreTwoPlayer2.Text = valor2.ToString();
                scoreTwoPlayer2.Visible = true;
            }
            else if (round == 3)
            {
                scoreThreePlayer1.Text = valor1.ToString();
                scoreThreePlayer1.Visible = true;

                scoreThreePlayer2.Text = valor2.ToString();
                scoreThreePlayer2.Visible = true;
            }

            if (valor1 > valor2)
            {
                winnersForPlayer1++;
            }
            else if (valor2 > valor1)
            {
                winnersForPlayer2++;
            }

            if (winnersForPlayer1 == 2 || winnersForPlayer2 == 2 || round == 3)
            {
                winner.Visible = true;

                if (winnersForPlayer1 > winnersForPlayer2)
                    winner.Text = player1.Text + " é o vencedor!";
                else if (winnersForPlayer2 > winnersForPlayer1)
                    winner.Text = player2.Text + " é o vencedor!";
                else
                    winner.Text = "Empate, nenhum jogador venceu!";
            }
            else
            {
                player1.Enabled = true;
                player2.Enabled = true;
            }
        }

        private void selectHackDiceValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
