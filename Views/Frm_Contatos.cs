﻿using Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.Views
{
    public partial class Frm_Contatos : Form
    {
        public Frm_Contatos()
        {
            InitializeComponent();
            Atualizador_DataGrid();

        }

        private void Atualizador_DataGrid()
        {
            ContatosController contatosController = new ContatosController();
            DataTable tabela = contatosController.GetContatos();
            dgv_Contatos.DataSource = tabela;
        }

        private void btn_cadastrar_contato_Click(object sender, EventArgs e)
        {
            string criar_nome_contato = txb_Contato.Text;

            string criar_telefone_contato = txb_Telefone.Text;

            string criar_categoria_contato = cbx_Categoria.Text;

            ContatosController contatosController = new ContatosController();

            bool resultado = contatosController.AddContato(criar_nome_contato, criar_telefone_contato, criar_categoria_contato);

            Atualizador_DataGrid();

            if (resultado == true)
            {
                MessageBox.Show("Cadastro efetuado com Sucesso");
            }
        }

        private void btn_atualizar_contato_Click(object sender, EventArgs e)
        {
            int cod_contato = Convert.ToInt32(dgv_Contatos.SelectedRows[0].Cells[0].Value);

            string contato = txb_Contato.Text;

            string telefone = txb_Telefone.Text;

            string categoria = cbx_Categoria.Text;

            ContatosController contatosController = new ContatosController();

            contatosController.AlterContato(cod_contato, contato, telefone, categoria);

            Atualizador_DataGrid();
        }

        private void btn_excluir_contato_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dgv_Contatos.SelectedRows[0].Cells[0].Value);

            ContatosController contatosController = new ContatosController();

            contatosController.DelContato(codigo);

            Atualizador_DataGrid();


        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Contatos_Load_1(object sender, EventArgs e)
        {
            CategoriaController categoriaController = new CategoriaController();

            DataTable tabela = categoriaController.GetCategorias();

            cbx_Categoria.DataSource = tabela;
            cbx_Categoria.DisplayMember = "categoria";
        }
    }
}
