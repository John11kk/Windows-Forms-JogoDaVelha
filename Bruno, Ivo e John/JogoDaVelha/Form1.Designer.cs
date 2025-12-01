namespace JogoDaVelha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelPrincipal = new Panel();
            btnSair = new Button();
            btnReiniciar = new Button();
            btnIniciar = new Button();
            gbOpcoes = new GroupBox();
            rbO = new RadioButton();
            rbX = new RadioButton();
            gbEmpate = new GroupBox();
            lblEmpate = new Label();
            label1 = new Label();
            gbPlacar = new GroupBox();
            lblPontosJ2 = new Label();
            lblPontosJ1 = new Label();
            lblPlacarJ2 = new Label();
            lblPlacarJ1 = new Label();
            gbJogadores = new GroupBox();
            tbJogador1 = new TextBox();
            tbJogador2 = new TextBox();
            btnJogo1 = new Button();
            btnJogo2 = new Button();
            btnJogo3 = new Button();
            btnJogo4 = new Button();
            btnJogo5 = new Button();
            btnJogo6 = new Button();
            btnJogo7 = new Button();
            btnJogo8 = new Button();
            btnJogo9 = new Button();
            panelPrincipal.SuspendLayout();
            gbOpcoes.SuspendLayout();
            gbEmpate.SuspendLayout();
            gbPlacar.SuspendLayout();
            gbJogadores.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.LightSeaGreen;
            panelPrincipal.Controls.Add(btnSair);
            panelPrincipal.Controls.Add(btnReiniciar);
            panelPrincipal.Controls.Add(btnIniciar);
            panelPrincipal.Controls.Add(gbOpcoes);
            panelPrincipal.Controls.Add(gbEmpate);
            panelPrincipal.Controls.Add(gbPlacar);
            panelPrincipal.Controls.Add(gbJogadores);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(709, 219);
            panelPrincipal.TabIndex = 0;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.ForeColor = Color.LightSeaGreen;
            btnSair.Location = new Point(560, 165);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(112, 26);
            btnSair.TabIndex = 4;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReiniciar.ForeColor = Color.LightSeaGreen;
            btnReiniciar.Location = new Point(407, 165);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(147, 26);
            btnReiniciar.TabIndex = 3;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciar.ForeColor = Color.LightSeaGreen;
            btnIniciar.Location = new Point(289, 165);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(112, 26);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // gbOpcoes
            // 
            gbOpcoes.Controls.Add(rbO);
            gbOpcoes.Controls.Add(rbX);
            gbOpcoes.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            gbOpcoes.ForeColor = Color.White;
            gbOpcoes.Location = new Point(23, 129);
            gbOpcoes.Name = "gbOpcoes";
            gbOpcoes.Size = new Size(165, 77);
            gbOpcoes.TabIndex = 1;
            gbOpcoes.TabStop = false;
            gbOpcoes.Text = "Opções";
            gbOpcoes.Enter += gbOpcoes_Enter;
            // 
            // rbO
            // 
            rbO.AutoSize = true;
            rbO.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Bold, GraphicsUnit.Point);
            rbO.Location = new Point(89, 26);
            rbO.Name = "rbO";
            rbO.Size = new Size(68, 48);
            rbO.TabIndex = 1;
            rbO.TabStop = true;
            rbO.Text = "O";
            rbO.UseVisualStyleBackColor = true;
            // 
            // rbX
            // 
            rbX.AutoSize = true;
            rbX.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Bold, GraphicsUnit.Point);
            rbX.Location = new Point(16, 28);
            rbX.Name = "rbX";
            rbX.Size = new Size(63, 48);
            rbX.TabIndex = 0;
            rbX.TabStop = true;
            rbX.Text = "X";
            rbX.UseVisualStyleBackColor = true;
            rbX.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // gbEmpate
            // 
            gbEmpate.Controls.Add(lblEmpate);
            gbEmpate.Controls.Add(label1);
            gbEmpate.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            gbEmpate.ForeColor = Color.White;
            gbEmpate.Location = new Point(472, 23);
            gbEmpate.Name = "gbEmpate";
            gbEmpate.Size = new Size(200, 100);
            gbEmpate.TabIndex = 1;
            gbEmpate.TabStop = false;
            gbEmpate.Text = "Empate";
            // 
            // lblEmpate
            // 
            lblEmpate.AutoSize = true;
            lblEmpate.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmpate.Location = new Point(88, 49);
            lblEmpate.Name = "lblEmpate";
            lblEmpate.Size = new Size(0, 31);
            lblEmpate.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(0, 18);
            label1.TabIndex = 1;
            // 
            // gbPlacar
            // 
            gbPlacar.Controls.Add(lblPontosJ2);
            gbPlacar.Controls.Add(lblPontosJ1);
            gbPlacar.Controls.Add(lblPlacarJ2);
            gbPlacar.Controls.Add(lblPlacarJ1);
            gbPlacar.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            gbPlacar.ForeColor = Color.White;
            gbPlacar.Location = new Point(266, 23);
            gbPlacar.Name = "gbPlacar";
            gbPlacar.Size = new Size(200, 100);
            gbPlacar.TabIndex = 1;
            gbPlacar.TabStop = false;
            gbPlacar.Text = "Placar";
            // 
            // lblPontosJ2
            // 
            lblPontosJ2.AutoSize = true;
            lblPontosJ2.Location = new Point(124, 65);
            lblPontosJ2.Name = "lblPontosJ2";
            lblPontosJ2.Size = new Size(0, 29);
            lblPontosJ2.TabIndex = 3;
            // 
            // lblPontosJ1
            // 
            lblPontosJ1.AutoSize = true;
            lblPontosJ1.Location = new Point(37, 62);
            lblPontosJ1.Name = "lblPontosJ1";
            lblPontosJ1.Size = new Size(0, 29);
            lblPontosJ1.TabIndex = 2;
            // 
            // lblPlacarJ2
            // 
            lblPlacarJ2.AutoSize = true;
            lblPlacarJ2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlacarJ2.Location = new Point(99, 31);
            lblPlacarJ2.Name = "lblPlacarJ2";
            lblPlacarJ2.Size = new Size(0, 18);
            lblPlacarJ2.TabIndex = 1;
            lblPlacarJ2.Click += lblPlacarJ2_Click;
            // 
            // lblPlacarJ1
            // 
            lblPlacarJ1.AutoSize = true;
            lblPlacarJ1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlacarJ1.Location = new Point(6, 33);
            lblPlacarJ1.Name = "lblPlacarJ1";
            lblPlacarJ1.Size = new Size(0, 18);
            lblPlacarJ1.TabIndex = 0;
            lblPlacarJ1.Click += lblPlacarJ1_Click;
            // 
            // gbJogadores
            // 
            gbJogadores.Controls.Add(tbJogador1);
            gbJogadores.Controls.Add(tbJogador2);
            gbJogadores.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            gbJogadores.ForeColor = Color.White;
            gbJogadores.Location = new Point(23, 23);
            gbJogadores.Name = "gbJogadores";
            gbJogadores.Size = new Size(237, 100);
            gbJogadores.TabIndex = 0;
            gbJogadores.TabStop = false;
            gbJogadores.Text = "Jogadores";
            // 
            // tbJogador1
            // 
            tbJogador1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbJogador1.Location = new Point(19, 34);
            tbJogador1.Multiline = true;
            tbJogador1.Name = "tbJogador1";
            tbJogador1.Size = new Size(193, 27);
            tbJogador1.TabIndex = 2;
            // 
            // tbJogador2
            // 
            tbJogador2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbJogador2.Location = new Point(19, 67);
            tbJogador2.Multiline = true;
            tbJogador2.Name = "tbJogador2";
            tbJogador2.Size = new Size(193, 27);
            tbJogador2.TabIndex = 1;
            // 
            // btnJogo1
            // 
            btnJogo1.BackColor = Color.LightSeaGreen;
            btnJogo1.Cursor = Cursors.Hand;
            btnJogo1.Enabled = false;
            btnJogo1.FlatStyle = FlatStyle.Flat;
            btnJogo1.Font = new Font("Microsoft Sans Serif", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnJogo1.Location = new Point(225, 224);
            btnJogo1.Name = "btnJogo1";
            btnJogo1.Size = new Size(85, 71);
            btnJogo1.TabIndex = 12;
            btnJogo1.TabStop = false;
            btnJogo1.UseVisualStyleBackColor = false;
            btnJogo1.Click += ColocarXO;
            // 
            // btnJogo2
            // 
            btnJogo2.BackColor = Color.LightSeaGreen;
            btnJogo2.Cursor = Cursors.Hand;
            btnJogo2.Enabled = false;
            btnJogo2.FlatStyle = FlatStyle.Flat;
            btnJogo2.Font = new Font("Microsoft Sans Serif", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnJogo2.Location = new Point(316, 225);
            btnJogo2.Name = "btnJogo2";
            btnJogo2.Size = new Size(85, 71);
            btnJogo2.TabIndex = 13;
            btnJogo2.TabStop = false;
            btnJogo2.UseVisualStyleBackColor = false;
            btnJogo2.Click += ColocarXO;
            // 
            // btnJogo3
            // 
            btnJogo3.BackColor = Color.LightSeaGreen;
            btnJogo3.Cursor = Cursors.Hand;
            btnJogo3.Enabled = false;
            btnJogo3.FlatStyle = FlatStyle.Flat;
            btnJogo3.Font = new Font("Microsoft Sans Serif", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnJogo3.Location = new Point(407, 225);
            btnJogo3.Name = "btnJogo3";
            btnJogo3.Size = new Size(85, 71);
            btnJogo3.TabIndex = 14;
            btnJogo3.TabStop = false;
            btnJogo3.UseVisualStyleBackColor = false;
            btnJogo3.Click += ColocarXO;
            // 
            // btnJogo4
            // 
            btnJogo4.BackColor = Color.LightSeaGreen;
            btnJogo4.Cursor = Cursors.Hand;
            btnJogo4.Enabled = false;
            btnJogo4.FlatStyle = FlatStyle.Flat;
            btnJogo4.Font = new Font("Microsoft Sans Serif", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnJogo4.Location = new Point(225, 301);
            btnJogo4.Name = "btnJogo4";
            btnJogo4.Size = new Size(85, 71);
            btnJogo4.TabIndex = 15;
            btnJogo4.TabStop = false;
            btnJogo4.UseVisualStyleBackColor = false;
            btnJogo4.Click += ColocarXO;
            // 
            // btnJogo5
            // 
            btnJogo5.BackColor = Color.LightSeaGreen;
            btnJogo5.Cursor = Cursors.Hand;
            btnJogo5.Enabled = false;
            btnJogo5.FlatStyle = FlatStyle.Flat;
            btnJogo5.Font = new Font("Microsoft Sans Serif", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnJogo5.Location = new Point(316, 301);
            btnJogo5.Name = "btnJogo5";
            btnJogo5.Size = new Size(85, 71);
            btnJogo5.TabIndex = 16;
            btnJogo5.TabStop = false;
            btnJogo5.UseVisualStyleBackColor = false;
            btnJogo5.Click += ColocarXO;
            // 
            // btnJogo6
            // 
            btnJogo6.BackColor = Color.LightSeaGreen;
            btnJogo6.Cursor = Cursors.Hand;
            btnJogo6.Enabled = false;
            btnJogo6.FlatStyle = FlatStyle.Flat;
            btnJogo6.Font = new Font("Microsoft Sans Serif", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnJogo6.Location = new Point(407, 301);
            btnJogo6.Name = "btnJogo6";
            btnJogo6.Size = new Size(85, 71);
            btnJogo6.TabIndex = 17;
            btnJogo6.TabStop = false;
            btnJogo6.UseVisualStyleBackColor = false;
            btnJogo6.Click += ColocarXO;
            // 
            // btnJogo7
            // 
            btnJogo7.BackColor = Color.LightSeaGreen;
            btnJogo7.Cursor = Cursors.Hand;
            btnJogo7.Enabled = false;
            btnJogo7.FlatStyle = FlatStyle.Flat;
            btnJogo7.Font = new Font("Microsoft Sans Serif", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnJogo7.Location = new Point(225, 378);
            btnJogo7.Name = "btnJogo7";
            btnJogo7.Size = new Size(85, 71);
            btnJogo7.TabIndex = 18;
            btnJogo7.TabStop = false;
            btnJogo7.UseVisualStyleBackColor = false;
            btnJogo7.Click += ColocarXO;
            // 
            // btnJogo8
            // 
            btnJogo8.BackColor = Color.LightSeaGreen;
            btnJogo8.Cursor = Cursors.Hand;
            btnJogo8.Enabled = false;
            btnJogo8.FlatStyle = FlatStyle.Flat;
            btnJogo8.Font = new Font("Microsoft Sans Serif", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnJogo8.Location = new Point(316, 378);
            btnJogo8.Name = "btnJogo8";
            btnJogo8.Size = new Size(85, 71);
            btnJogo8.TabIndex = 19;
            btnJogo8.TabStop = false;
            btnJogo8.UseVisualStyleBackColor = false;
            btnJogo8.Click += ColocarXO;
            // 
            // btnJogo9
            // 
            btnJogo9.BackColor = Color.LightSeaGreen;
            btnJogo9.Cursor = Cursors.Hand;
            btnJogo9.Enabled = false;
            btnJogo9.FlatStyle = FlatStyle.Flat;
            btnJogo9.Font = new Font("Microsoft Sans Serif", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnJogo9.Location = new Point(407, 378);
            btnJogo9.Name = "btnJogo9";
            btnJogo9.Size = new Size(85, 71);
            btnJogo9.TabIndex = 20;
            btnJogo9.TabStop = false;
            btnJogo9.UseVisualStyleBackColor = false;
            btnJogo9.Click += ColocarXO;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 461);
            Controls.Add(btnJogo9);
            Controls.Add(btnJogo8);
            Controls.Add(btnJogo7);
            Controls.Add(btnJogo6);
            Controls.Add(btnJogo5);
            Controls.Add(btnJogo4);
            Controls.Add(btnJogo3);
            Controls.Add(btnJogo2);
            Controls.Add(btnJogo1);
            Controls.Add(panelPrincipal);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Jogo Da Velha";
            panelPrincipal.ResumeLayout(false);
            gbOpcoes.ResumeLayout(false);
            gbOpcoes.PerformLayout();
            gbEmpate.ResumeLayout(false);
            gbEmpate.PerformLayout();
            gbPlacar.ResumeLayout(false);
            gbPlacar.PerformLayout();
            gbJogadores.ResumeLayout(false);
            gbJogadores.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private GroupBox gbOpcoes;
        private RadioButton rbX;
        private GroupBox gbEmpate;
        private GroupBox gbPlacar;
        private GroupBox gbJogadores;
        private Button btnSair;
        private Button btnReiniciar;
        private Button btnIniciar;
        private RadioButton rbO;
        private TextBox tbJogador2;
        private Label label1;
        private Label lblPlacarJ1;
        private TextBox tbJogador1;
        private Label lblPlacarJ2;
        private Button btnJogo1;
        private Button btnJogo2;
        private Button btnJogo3;
        private Button btnJogo4;
        private Button btnJogo5;
        private Button btnJogo6;
        private Button btnJogo7;
        private Button btnJogo8;
        private Button btnJogo9;
        private Label lblPontosJ2;
        private Label lblPontosJ1;
        private Label lblEmpate;
    }
}