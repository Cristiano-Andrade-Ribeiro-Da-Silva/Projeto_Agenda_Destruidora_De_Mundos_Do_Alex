﻿namespace Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.Views
{
    partial class FrmCadastrarCategoriacs
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
            txt_criar_categoria = new TextBox();
            btn_cadastrar_categoria = new Button();
            groupBox_nova_categoria = new GroupBox();
            btn_Voltar = new Button();
            dgv_Categoria = new DataGridView();
            btn_excluir_categoria = new Button();
            groupBox_Tabela = new GroupBox();
            groupBox_nova_categoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Categoria).BeginInit();
            groupBox_Tabela.SuspendLayout();
            SuspendLayout();
            // 
            // txt_criar_categoria
            // 
            txt_criar_categoria.Location = new Point(71, 42);
            txt_criar_categoria.Margin = new Padding(3, 2, 3, 2);
            txt_criar_categoria.Name = "txt_criar_categoria";
            txt_criar_categoria.Size = new Size(110, 23);
            txt_criar_categoria.TabIndex = 0;
            // 
            // btn_cadastrar_categoria
            // 
            btn_cadastrar_categoria.Location = new Point(84, 98);
            btn_cadastrar_categoria.Margin = new Padding(3, 2, 3, 2);
            btn_cadastrar_categoria.Name = "btn_cadastrar_categoria";
            btn_cadastrar_categoria.Size = new Size(82, 22);
            btn_cadastrar_categoria.TabIndex = 1;
            btn_cadastrar_categoria.Text = "Cadastrar";
            btn_cadastrar_categoria.UseVisualStyleBackColor = true;
            btn_cadastrar_categoria.Click += btn_cadastrar_categoria_Click;
            // 
            // groupBox_nova_categoria
            // 
            groupBox_nova_categoria.Controls.Add(txt_criar_categoria);
            groupBox_nova_categoria.Controls.Add(btn_cadastrar_categoria);
            groupBox_nova_categoria.Location = new Point(35, 12);
            groupBox_nova_categoria.Name = "groupBox_nova_categoria";
            groupBox_nova_categoria.Size = new Size(250, 150);
            groupBox_nova_categoria.TabIndex = 3;
            groupBox_nova_categoria.TabStop = false;
            groupBox_nova_categoria.Text = "Insira a nova categoria";
            // 
            // btn_Voltar
            // 
            btn_Voltar.Location = new Point(250, 315);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(82, 23);
            btn_Voltar.TabIndex = 4;
            btn_Voltar.Text = "Voltar";
            btn_Voltar.UseVisualStyleBackColor = true;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // dgv_Categoria
            // 
            dgv_Categoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Categoria.Location = new Point(19, 22);
            dgv_Categoria.Name = "dgv_Categoria";
            dgv_Categoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Categoria.Size = new Size(200, 200);
            dgv_Categoria.TabIndex = 5;
            // 
            // btn_excluir_categoria
            // 
            btn_excluir_categoria.Location = new Point(86, 245);
            btn_excluir_categoria.Margin = new Padding(3, 2, 3, 2);
            btn_excluir_categoria.Name = "btn_excluir_categoria";
            btn_excluir_categoria.Size = new Size(82, 22);
            btn_excluir_categoria.TabIndex = 1;
            btn_excluir_categoria.Text = "Excluir";
            btn_excluir_categoria.UseVisualStyleBackColor = true;
            btn_excluir_categoria.Click += btn_excluir_categoria_Click;
            // 
            // groupBox_Tabela
            // 
            groupBox_Tabela.Controls.Add(dgv_Categoria);
            groupBox_Tabela.Controls.Add(btn_excluir_categoria);
            groupBox_Tabela.Location = new Point(375, 12);
            groupBox_Tabela.Name = "groupBox_Tabela";
            groupBox_Tabela.Size = new Size(240, 272);
            groupBox_Tabela.TabIndex = 6;
            groupBox_Tabela.TabStop = false;
            groupBox_Tabela.Text = "Categorias";
            // 
            // FrmCadastrarCategoriacs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 350);
            Controls.Add(groupBox_Tabela);
            Controls.Add(btn_Voltar);
            Controls.Add(groupBox_nova_categoria);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmCadastrarCategoriacs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCadastrarCategoriacs";
            Load += FrmCadastrarCategoriacs_Load;
            groupBox_nova_categoria.ResumeLayout(false);
            groupBox_nova_categoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Categoria).EndInit();
            groupBox_Tabela.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_criar_categoria;
        private Button btn_cadastrar_categoria;
        private GroupBox groupBox_nova_categoria;
        private Button btn_Voltar;
        private DataGridView dgv_Categoria;
        private Button btn_excluir_categoria;
        private GroupBox groupBox_Tabela;
    }
}