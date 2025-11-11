namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        string turno;
        string jogador1 = "", jogador2 = "";
        int jogadas;
        string jogador1XO, jogador2XO;
        int pontosJ1, pontosJ2;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Deseja sair do jogo?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is Button btn && btn.Name.StartsWith("btnJogo"))
                {
                    btn.Text = "";
                    btn.Enabled = true;
                }
            }

            jogadas = 0;
            turno = jogador1XO; // jogador 1 sempre começa
        }

        private void tbJogador2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPlacarJ1_Click(object sender, EventArgs e)
        {

        }

        private void lblPlacarJ2_Click(object sender, EventArgs e)
        {

        }

        private void gbOpcoes_Enter(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            bool jogador1Vazio = string.IsNullOrWhiteSpace(tbJogador1.Text);
            bool jogador2Vazio = string.IsNullOrWhiteSpace(tbJogador2.Text);

            if (jogador1Vazio || jogador2Vazio)
            {

                string mensagem = "O nome do(s) seguinte(s) jogador(es) deve(m) ser preenchido(s):\n";
                if (jogador1Vazio) mensagem += "- Jogador 1\n";
                if (jogador2Vazio) mensagem += "- Jogador 2\n";

                MessageBox.Show(mensagem, "Preenchimento Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!string.IsNullOrWhiteSpace(tbJogador1.Text) && !string.IsNullOrWhiteSpace(tbJogador2.Text))
            {
                if (tbJogador1.Text.Trim().Equals(tbJogador2.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Não é permitido nomes iguais. Tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (!rbO.Checked && !rbX.Checked)
            {
                MessageBox.Show("Selecione uma alternativa entre X e O.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nomeJogador1 = tbJogador1.Text.Trim();
            MessageBox.Show($"{nomeJogador1} começa!", "Início do Jogo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnJogo1.Enabled = true;
            btnJogo2.Enabled = true;
            btnJogo3.Enabled = true;
            btnJogo4.Enabled = true;
            btnJogo5.Enabled = true;
            btnJogo6.Enabled = true;
            btnJogo7.Enabled = true;
            btnJogo8.Enabled = true;
            btnJogo9.Enabled = true;

            rbX.Enabled = false;
            rbO.Enabled = false;

            //Checar qual o 1° quer jogar: X ou O
            if (rbX.Checked)
            {
                jogador1XO = "x";
                jogador2XO = "o";
            }
            else if (rbO.Checked)
            {
                jogador1XO = "o";
                jogador2XO = "x";
            }

            // Define o turno inicial e zera jogadas
            turno = jogador1XO;
            jogadas = 0;


        }

        private void VerificarGanhador()
        {
            //x
            //vertical
            if (btnJogo1.Text == "x" && btnJogo2.Text == "x" && btnJogo3.Text == "x")
            {
                if (jogador1XO == "X")
                {
                    MessageBox.Show($"{tbJogador1.Text} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ1++;
                }
                if (jogador2XO == "X")
                {
                    MessageBox.Show($"{tbJogador2} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ2++;
                }
            }
            if (btnJogo4.Text == "x" && btnJogo5.Text == "x" && btnJogo6.Text == "x")
            {
                if (jogador1XO == "X")
                {
                    MessageBox.Show($"{tbJogador1} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ1++;
                }
                if (jogador2XO == "X")
                {
                    MessageBox.Show($"{tbJogador2} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ2++;
                }
            }
            if (btnJogo7.Text == "x" && btnJogo8.Text == "x" && btnJogo9.Text == "x")
            {
                if (jogador1XO == "X")
                {
                    MessageBox.Show($"{tbJogador1} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ1++;
                }
                if (jogador2XO == "X")
                {
                    MessageBox.Show($"{tbJogador2} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ2++;
                }
            }
            //horizontal
            if (btnJogo1.Text == "x" && btnJogo4.Text == "x" && btnJogo7.Text == "x")
            {
                if (jogador1XO == "X")
                {
                    MessageBox.Show($"{tbJogador1} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ1++;
                }
                if (jogador2XO == "X")
                {
                    MessageBox.Show($"{tbJogador2} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ2++;
                }
            }
            if (btnJogo2.Text == "x" && btnJogo5.Text == "x" && btnJogo8.Text == "x")
            {
                if (jogador1XO == "X")
                {
                    MessageBox.Show($"{tbJogador1} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ1++;
                }
                if (jogador2XO == "X")
                {
                    MessageBox.Show($"{tbJogador2} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ2++;
                }
            }
            if (btnJogo3.Text == "x" && btnJogo6.Text == "x" && btnJogo9.Text == "x")
            {
                if (jogador1XO == "X")
                {
                    MessageBox.Show($"{tbJogador1.Text} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ1++;
                }
                if (jogador2XO == "X")
                {
                    MessageBox.Show($"{tbJogador2.Text} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ2++;
                }
            }
            //Diagonal
            if (btnJogo1.Text == "x" && btnJogo5.Text == "x" && btnJogo9.Text == "x")
            {
                if (jogador1XO == "X")
                {
                    MessageBox.Show($"{tbJogador1.Text} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ1++;
                }
                if (jogador2XO == "X")
                {
                    MessageBox.Show($"{tbJogador2.Text} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ2++;
                }
            }
            if (btnJogo3.Text == "x" && btnJogo5.Text == "x" && btnJogo7.Text == "x")
            {
                if (jogador1XO == "X")
                {
                    MessageBox.Show($"{tbJogador1.Text} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ1++;
                }
                if (jogador2XO == "X")
                {
                    MessageBox.Show($"{tbJogador2.Text} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ2++;
                }
            }

            //O
            //vertical
            if (btnJogo1.Text == "O" && btnJogo2.Text == "O" && btnJogo3.Text == "O")
            {
                if (jogador1XO == "o")
                {
                    MessageBox.Show($"{tbJogador1.Text} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ1++;
                }
                if (jogador2XO == "o")
                {
                    MessageBox.Show($"{tbJogador2.Text} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ2++;
                }
            }
            if (btnJogo4.Text == "O" && btnJogo5.Text == "O" && btnJogo6.Text == "O")
            {
                if (jogador1XO == "o")
                {
                    MessageBox.Show($"{tbJogador1.Text} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ1++;
                }
                if (jogador2XO == "o")
                {
                    MessageBox.Show($"{tbJogador2.Text} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ2++;
                }
            }
            if (btnJogo7.Text == "O" && btnJogo8.Text == "O" && btnJogo9.Text == "O")
            {
                if (jogador1XO == "o")
                {
                    MessageBox.Show($"{tbJogador1.Text} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ1++;
                }
                if (jogador2XO == "o")
                {
                    MessageBox.Show($"{tbJogador2.Text} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ2++;
                }
            }
            //horizontal
            if (btnJogo1.Text == "O" && btnJogo4.Text == "O" && btnJogo7.Text == "O")
            {
                if (jogador1XO == "o")
                {
                    MessageBox.Show($"{tbJogador1.Text} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ1++;
                }
                if (jogador2XO == "o")
                {
                    MessageBox.Show($"{tbJogador2.Text} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ2++;
                }
            }
            if (btnJogo2.Text == "O" && btnJogo5.Text == "O" && btnJogo8.Text == "O")
            {
                if (jogador1XO == "o")
                {
                    MessageBox.Show($"{tbJogador1.Text} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ1++;
                }
                if (jogador2XO == "o")
                {
                    MessageBox.Show($"{tbJogador2.Text} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ2++;
                }
            }
            if (btnJogo3.Text == "O" && btnJogo6.Text == "O" && btnJogo9.Text == "O")
            {
                if (jogador1XO == "o")
                {
                    MessageBox.Show($"{tbJogador1.Text} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ1++;
                }
                if (jogador2XO == "o")
                {
                    MessageBox.Show($"{tbJogador2.Text} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ2++;
                }
            }
            //Diagonal
            if (btnJogo1.Text == "O" && btnJogo5.Text == "O" && btnJogo9.Text == "O")
            {
                if (jogador1XO == "o")
                {
                    MessageBox.Show($"{tbJogador1.Text} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ1++;
                }
                if (jogador2XO == "o")
                {
                    MessageBox.Show($"{tbJogador2.Text} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ2++;
                }
            }
            if (btnJogo3.Text == "O" && btnJogo5.Text == "O" && btnJogo7.Text == "O")
            {
                if (jogador1XO == "o")
                {
                    MessageBox.Show($"{tbJogador1.Text} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ1++;
                }
                if (jogador2XO == "o")
                {
                    MessageBox.Show($"{tbJogador2.Text} Ganhou o Jogo", "Fim de Jogo");
                    pontosJ2++;
                }
            }
        }

        private void ColocarXO(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Se o botão já foi clicado, não faz nada
            if (!btn.Enabled)
                return;

            // Coloca o símbolo do jogador atual
            if (turno == jogador1XO)
            {
                btn.Text = jogador1XO.ToUpper();
                turno = jogador2XO; // troca para o outro jogador
            }
            else
            {
                btn.Text = jogador2XO.ToUpper();
                turno = jogador1XO;
            }

            btn.Enabled = false; // desativa o botão clicado
            jogadas++;

            // Verifica se alguém ganhou
            VerificarGanhador();

            // Se chegou a 9 jogadas e ninguém ganhou, é empate
            if (jogadas == 9)

            {
                MessageBox.Show("O jogo terminou em empate!", "Fim de Jogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}