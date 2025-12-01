using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        string turno;
        string jogador1 = "", jogador2 = "";
        int jogadas, Empates;
        string jogador1XO, jogador2XO;
        int pontosJ1, pontosJ2;
        bool tudocerto = true;

        public Form1()
        {
            InitializeComponent();
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
            if (!string.IsNullOrEmpty(jogador1XO))
            {
                turno = jogador1XO;
            }
            else
            {
                turno = "X";
            }
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
                tudocerto = false;
                return;
            }

            if (tbJogador1.Text.Trim().Equals(tbJogador2.Text.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Não é permitido nomes iguais. Tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tudocerto = false;
                return;
            }

            if (!rbO.Checked && !rbX.Checked)
            {
                MessageBox.Show("Selecione uma alternativa entre X e O.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tudocerto = false;
                return;
            }

            tudocerto = true;
            if (tudocerto)
            {
                btnIniciar.Enabled = false;
                tbJogador1.Enabled = false;
                tbJogador2.Enabled = false;
                rbX.Enabled = false;
                rbO.Enabled = false;

                btnJogo1.Enabled = true;
                btnJogo2.Enabled = true;
                btnJogo3.Enabled = true;
                btnJogo4.Enabled = true;
                btnJogo5.Enabled = true;
                btnJogo6.Enabled = true;
                btnJogo7.Enabled = true;
                btnJogo8.Enabled = true;
                btnJogo9.Enabled = true;

                jogador1 = tbJogador1.Text.Trim();
                jogador2 = tbJogador2.Text.Trim();

                if (rbX.Checked)
                {
                    jogador1XO = "X";
                    jogador2XO = "O";
                }
                else
                {
                    jogador1XO = "O";
                    jogador2XO = "X";
                }

                turno = jogador1XO;
                jogadas = 0;

                pontosJ1 = 0;
                pontosJ2 = 0;
                lblPlacarJ1.Text = jogador1;
                lblPlacarJ2.Text = jogador2;
                lblPontosJ1.Text = pontosJ1.ToString();
                lblPontosJ2.Text = pontosJ2.ToString();
                lblEmpate.Text = Empates.ToString();

                MessageBox.Show($"{jogador1} começa!", "Início do Jogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void DesabilitarBotoesJogo()
        {
            foreach (Control c in Controls)
            {
                if (c is Button btn && btn.Name.StartsWith("btnJogo"))
                {
                    btn.Enabled = false;
                }
            }
        }

        private bool ChecarCombinacao(Button b1, Button b2, Button b3)
        {
            string simbolo = b1.Text;

            if (string.IsNullOrWhiteSpace(simbolo) || b1.Text != b2.Text || b2.Text != b3.Text)
            {
                return false;
            }

            DesabilitarBotoesJogo();

            string nomeVencedor;
            bool jogador1Venceu = simbolo == jogador1XO;

            if (jogador1Venceu)
            {
                pontosJ1++;
                lblPontosJ1.Text = pontosJ1.ToString();
                nomeVencedor = jogador1;
            }
            else
            {
                pontosJ2++;
                lblPontosJ2.Text = pontosJ2.ToString();
                nomeVencedor = jogador2;
            }

            MessageBox.Show($"{nomeVencedor} Ganhou o Jogo!", "Fim de Jogo");
            return true;
        }


        private void VerificarGanhador()
        {

            // Horizontais
            if (ChecarCombinacao(btnJogo1, btnJogo2, btnJogo3)) return;
            if (ChecarCombinacao(btnJogo4, btnJogo5, btnJogo6)) return;
            if (ChecarCombinacao(btnJogo7, btnJogo8, btnJogo9)) return;

            // Verticais
            if (ChecarCombinacao(btnJogo1, btnJogo4, btnJogo7)) return;
            if (ChecarCombinacao(btnJogo2, btnJogo5, btnJogo8)) return;
            if (ChecarCombinacao(btnJogo3, btnJogo6, btnJogo9)) return;

            // Diagonais
            if (ChecarCombinacao(btnJogo1, btnJogo5, btnJogo9)) return;
            if (ChecarCombinacao(btnJogo3, btnJogo5, btnJogo7)) return;

            // Se chegou a 9 jogadas e ninguém ganhou
            if (jogadas == 9)
            {
                MessageBox.Show("O jogo terminou em empate!", "Fim de Jogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Empates++;
                lblEmpate.Text = Empates.ToString();
                DesabilitarBotoesJogo();
            }
        }


        private void ColocarXO(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (!tudocerto || !btn.Enabled)
                return;

            btn.Text = turno;
            btn.Enabled = false;
            jogadas++;

            turno = (turno == jogador1XO) ? jogador2XO : jogador1XO;

            if (jogadas >= 5)
            {
                VerificarGanhador();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) 
        {
        
        }
        private void textBox1_TextChanged(object sender, EventArgs e) 
        {
        
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
    }
}