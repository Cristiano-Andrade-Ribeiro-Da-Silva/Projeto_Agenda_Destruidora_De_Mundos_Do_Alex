namespace Projeto_Agenda_Destruidora_De_Mundos_Do_Alex
{
    partial class Frm_Tela_De_Cadastro
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
            lbl_senha = new Label();
            lbl_usuario = new Label();
            lbl_telefone = new Label();
            lbl_nome = new Label();
            botao_cadastrar_final = new Button();
            botao_cancelar = new Button();
            textBox_usuario = new TextBox();
            textBox_nome = new TextBox();
            textBox_telefone = new TextBox();
            textBox_senha = new TextBox();
            cadeado_trancado = new PictureBox();
            cadeado_destrancado = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)cadeado_trancado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cadeado_destrancado).BeginInit();
            SuspendLayout();
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lbl_senha.ForeColor = Color.White;
            lbl_senha.Location = new Point(43, 255);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(46, 16);
            lbl_senha.TabIndex = 9;
            lbl_senha.Text = "Senha";
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lbl_usuario.ForeColor = Color.White;
            lbl_usuario.Location = new Point(43, 88);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(54, 16);
            lbl_usuario.TabIndex = 6;
            lbl_usuario.Text = "Usuário";
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lbl_telefone.ForeColor = Color.White;
            lbl_telefone.Location = new Point(43, 171);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(60, 16);
            lbl_telefone.TabIndex = 13;
            lbl_telefone.Text = "Telefone";
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lbl_nome.ForeColor = Color.White;
            lbl_nome.Location = new Point(43, 4);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(43, 16);
            lbl_nome.TabIndex = 10;
            lbl_nome.Text = "Nome";
            // 
            // botao_cadastrar_final
            // 
            botao_cadastrar_final.BackColor = Color.DarkViolet;
            botao_cadastrar_final.FlatStyle = FlatStyle.Flat;
            botao_cadastrar_final.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic);
            botao_cadastrar_final.ForeColor = Color.White;
            botao_cadastrar_final.Location = new Point(43, 434);
            botao_cadastrar_final.Name = "botao_cadastrar_final";
            botao_cadastrar_final.Size = new Size(106, 37);
            botao_cadastrar_final.TabIndex = 15;
            botao_cadastrar_final.Text = "Cadastrar";
            botao_cadastrar_final.UseVisualStyleBackColor = false;
            botao_cadastrar_final.Click += botao_cadastrar_final_Click;
            // 
            // botao_cancelar
            // 
            botao_cancelar.BackColor = Color.DarkViolet;
            botao_cancelar.FlatStyle = FlatStyle.Flat;
            botao_cancelar.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic);
            botao_cancelar.ForeColor = Color.White;
            botao_cancelar.Location = new Point(237, 434);
            botao_cancelar.Name = "botao_cancelar";
            botao_cancelar.Size = new Size(106, 37);
            botao_cancelar.TabIndex = 14;
            botao_cancelar.Text = "Cancelar";
            botao_cancelar.UseVisualStyleBackColor = false;
            botao_cancelar.Click += botao_cancelar_Click;
            // 
            // textBox_usuario
            // 
            textBox_usuario.BackColor = Color.DarkViolet;
            textBox_usuario.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox_usuario.ForeColor = Color.White;
            textBox_usuario.Location = new Point(43, 124);
            textBox_usuario.Name = "textBox_usuario";
            textBox_usuario.Size = new Size(300, 22);
            textBox_usuario.TabIndex = 17;
            textBox_usuario.TextAlign = HorizontalAlignment.Center;
            textBox_usuario.TextChanged += textBox_usuario_TextChanged;
            // 
            // textBox_nome
            // 
            textBox_nome.BackColor = Color.DarkViolet;
            textBox_nome.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox_nome.ForeColor = Color.White;
            textBox_nome.Location = new Point(43, 37);
            textBox_nome.Name = "textBox_nome";
            textBox_nome.Size = new Size(300, 22);
            textBox_nome.TabIndex = 16;
            textBox_nome.TextAlign = HorizontalAlignment.Center;
            textBox_nome.TextChanged += textBox_nome_TextChanged;
            // 
            // textBox_telefone
            // 
            textBox_telefone.BackColor = Color.DarkViolet;
            textBox_telefone.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox_telefone.ForeColor = Color.White;
            textBox_telefone.Location = new Point(43, 204);
            textBox_telefone.Name = "textBox_telefone";
            textBox_telefone.Size = new Size(300, 22);
            textBox_telefone.TabIndex = 18;
            textBox_telefone.TextAlign = HorizontalAlignment.Center;
            textBox_telefone.TextChanged += textBox_telefone_TextChanged;
            // 
            // textBox_senha
            // 
            textBox_senha.BackColor = Color.DarkViolet;
            textBox_senha.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox_senha.ForeColor = Color.White;
            textBox_senha.Location = new Point(43, 291);
            textBox_senha.Name = "textBox_senha";
            textBox_senha.PasswordChar = '☢';
            textBox_senha.Size = new Size(300, 22);
            textBox_senha.TabIndex = 19;
            textBox_senha.TextAlign = HorizontalAlignment.Center;
            textBox_senha.TextChanged += textBox_senha_TextChanged;
            // 
            // cadeado_trancado
            // 
            cadeado_trancado.Image = Properties.Resources.cadeado_2_trancado;
            cadeado_trancado.Location = new Point(143, 328);
            cadeado_trancado.Name = "cadeado_trancado";
            cadeado_trancado.Size = new Size(100, 100);
            cadeado_trancado.SizeMode = PictureBoxSizeMode.StretchImage;
            cadeado_trancado.TabIndex = 20;
            cadeado_trancado.TabStop = false;
            // 
            // cadeado_destrancado
            // 
            cadeado_destrancado.Image = Properties.Resources.cadeado_2_destrancado;
            cadeado_destrancado.Location = new Point(143, 328);
            cadeado_destrancado.Name = "cadeado_destrancado";
            cadeado_destrancado.Size = new Size(100, 100);
            cadeado_destrancado.SizeMode = PictureBoxSizeMode.StretchImage;
            cadeado_destrancado.TabIndex = 21;
            cadeado_destrancado.TabStop = false;
            cadeado_destrancado.Visible = false;
            // 
            // Frm_Tela_De_Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(400, 500);
            Controls.Add(cadeado_destrancado);
            Controls.Add(cadeado_trancado);
            Controls.Add(textBox_senha);
            Controls.Add(textBox_telefone);
            Controls.Add(textBox_usuario);
            Controls.Add(textBox_nome);
            Controls.Add(botao_cadastrar_final);
            Controls.Add(botao_cancelar);
            Controls.Add(lbl_telefone);
            Controls.Add(lbl_nome);
            Controls.Add(lbl_senha);
            Controls.Add(lbl_usuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Tela_De_Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Tela_De_Cadastro";
            ((System.ComponentModel.ISupportInitialize)cadeado_trancado).EndInit();
            ((System.ComponentModel.ISupportInitialize)cadeado_destrancado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_senha;
        private Label lbl_usuario;
        private Label lbl_telefone;
        private Label lbl_nome;
        private Button botao_cadastrar_final;
        private Button botao_cancelar;
        private TextBox textBox_usuario;
        private TextBox textBox_nome;
        private TextBox textBox_telefone;
        private TextBox textBox_senha;
        private PictureBox cadeado_trancado;
        private PictureBox cadeado_destrancado;
    }
}