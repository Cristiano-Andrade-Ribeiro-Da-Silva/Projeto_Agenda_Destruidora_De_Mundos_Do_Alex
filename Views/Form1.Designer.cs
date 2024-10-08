namespace Projeto_Agenda_Destruidora_De_Mundos_Do_Alex
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
            botao_login = new Button();
            botao_cadastrar = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox_senha = new TextBox();
            textBox_usuario = new TextBox();
            cadeado_trancado = new PictureBox();
            cadeado_destrancado = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)cadeado_trancado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cadeado_destrancado).BeginInit();
            SuspendLayout();
            // 
            // botao_login
            // 
            botao_login.BackColor = Color.DodgerBlue;
            botao_login.Enabled = false;
            botao_login.FlatStyle = FlatStyle.Flat;
            botao_login.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic);
            botao_login.ForeColor = Color.White;
            botao_login.Location = new Point(49, 225);
            botao_login.Name = "botao_login";
            botao_login.Size = new Size(106, 37);
            botao_login.TabIndex = 0;
            botao_login.Text = "Login";
            botao_login.UseVisualStyleBackColor = false;
            // 
            // botao_cadastrar
            // 
            botao_cadastrar.BackColor = Color.DodgerBlue;
            botao_cadastrar.FlatStyle = FlatStyle.Flat;
            botao_cadastrar.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic);
            botao_cadastrar.ForeColor = Color.White;
            botao_cadastrar.Location = new Point(241, 225);
            botao_cadastrar.Name = "botao_cadastrar";
            botao_cadastrar.Size = new Size(106, 37);
            botao_cadastrar.TabIndex = 1;
            botao_cadastrar.Text = "Cadastrar";
            botao_cadastrar.UseVisualStyleBackColor = false;
            botao_cadastrar.Click += botao_cadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(49, 36);
            label1.Name = "label1";
            label1.Size = new Size(54, 16);
            label1.TabIndex = 2;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(49, 139);
            label2.Name = "label2";
            label2.Size = new Size(46, 16);
            label2.TabIndex = 5;
            label2.Text = "Senha";
            // 
            // textBox_senha
            // 
            textBox_senha.BackColor = Color.DodgerBlue;
            textBox_senha.Font = new Font("Arial", 9.75F, FontStyle.Italic);
            textBox_senha.ForeColor = Color.White;
            textBox_senha.Location = new Point(49, 178);
            textBox_senha.Name = "textBox_senha";
            textBox_senha.PasswordChar = '☢';
            textBox_senha.Size = new Size(298, 22);
            textBox_senha.TabIndex = 4;
            textBox_senha.TextAlign = HorizontalAlignment.Center;
            textBox_senha.TextChanged += textBox_senha_TextChanged;
            // 
            // textBox_usuario
            // 
            textBox_usuario.BackColor = Color.DodgerBlue;
            textBox_usuario.Font = new Font("Arial", 9.75F, FontStyle.Italic);
            textBox_usuario.ForeColor = Color.White;
            textBox_usuario.Location = new Point(49, 80);
            textBox_usuario.Name = "textBox_usuario";
            textBox_usuario.Size = new Size(298, 22);
            textBox_usuario.TabIndex = 3;
            textBox_usuario.TextAlign = HorizontalAlignment.Center;
            textBox_usuario.TextChanged += textBox_usuario_TextChanged;
            // 
            // cadeado_trancado
            // 
            cadeado_trancado.Image = Properties.Resources.cadeado_trancado;
            cadeado_trancado.Location = new Point(100, 300);
            cadeado_trancado.Name = "cadeado_trancado";
            cadeado_trancado.Size = new Size(200, 200);
            cadeado_trancado.SizeMode = PictureBoxSizeMode.StretchImage;
            cadeado_trancado.TabIndex = 6;
            cadeado_trancado.TabStop = false;
            // 
            // cadeado_destrancado
            // 
            cadeado_destrancado.Image = Properties.Resources.cadeado_destrancado;
            cadeado_destrancado.Location = new Point(100, 300);
            cadeado_destrancado.Name = "cadeado_destrancado";
            cadeado_destrancado.Size = new Size(200, 200);
            cadeado_destrancado.SizeMode = PictureBoxSizeMode.StretchImage;
            cadeado_destrancado.TabIndex = 7;
            cadeado_destrancado.TabStop = false;
            cadeado_destrancado.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(400, 500);
            Controls.Add(cadeado_destrancado);
            Controls.Add(cadeado_trancado);
            Controls.Add(label2);
            Controls.Add(textBox_senha);
            Controls.Add(textBox_usuario);
            Controls.Add(label1);
            Controls.Add(botao_cadastrar);
            Controls.Add(botao_login);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)cadeado_trancado).EndInit();
            ((System.ComponentModel.ISupportInitialize)cadeado_destrancado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botao_login;
        private Button botao_cadastrar;
        private Label label1;
        private Label label2;
        private TextBox textBox_senha;
        private TextBox textBox_usuario;
        private PictureBox cadeado_trancado;
        private PictureBox cadeado_destrancado;
    }
}
