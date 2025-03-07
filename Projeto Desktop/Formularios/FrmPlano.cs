﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Desktop.Classes;

namespace Projeto_Desktop.Formularios
{
    public partial class FrmPlano : Form
    {
        Plano p;
        public FrmPlano()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            p = new Plano();
            if(txtNome.Text != string.Empty && txtDescricao.Text != string.Empty && txtValor.Text != string.Empty && txtDuracaoPlano.Text != string.Empty && txtLimitePedidos.Text != string.Empty)
            {
                p.InserirPlano(txtNome.Text, txtDescricao.Text, Convert.ToDouble(txtValor.Text), Convert.ToInt32(txtDuracaoPlano.Text), Convert.ToInt32(txtLimitePedidos.Text));
                if (p.Id > 0)
                {
                    MessageBox.Show("Plano cadastrado com sucesso !!");
                    txtId.Text = p.Id.ToString();
                    btnListar_Click(this, e);
                }
                else
                {
                    MessageBox.Show("Falha ao inserir o plano !!");
                }
            }            
            else
            {
                MessageBox.Show("É necessário preencher todos os campos");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            p = new Plano();
            if (txtNome.Text != string.Empty && txtDescricao.Text != string.Empty && txtValor.Text != string.Empty && txtLimitePedidos.Text != string.Empty && txtId.Text != string.Empty)
            {
                if (p.AlterarPlano(Convert.ToInt32(txtId.Text), txtNome.Text, txtDescricao.Text, Convert.ToDouble(txtValor.Text), Convert.ToInt32(txtDuracaoPlano.Text), Convert.ToInt32(txtLimitePedidos.Text)))
                {
                    MessageBox.Show("Plano alterado com sucesso !");
                    btnListar_Click(this, null);
                }
                else
                {
                    MessageBox.Show("Falha ao inserir plano !");
                }
            }
            else
            {
                MessageBox.Show("É necessário preencher os campos para alterar");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            p = new Plano();
            List<Plano> lista = new List<Plano>();
            lista = p.ListarPlanos();
            if (lista.Count > 0)
            {
                dgvListarPlanos.DataSource = lista;
            }
            else
            {
                MessageBox.Show("Nenhum plano cadastrado");
            }            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            p = new Plano();
            if(txtId.Text != string.Empty)
            {
                p.ConsultarPlanoId(Convert.ToInt32(txtId.Text));
                txtDescricao.Text = p.DescricaoPlano;
                txtDuracaoPlano.Text = p.DuracaoPlano.ToString();
                txtId.Text = p.Id.ToString();
                txtLimitePedidos.Text = p.LimitePedido.ToString();
                txtNome.Text = p.NomePlano;
                txtValor.Text = p.ValorPlano.ToString("C");
            }
            else
            {
                MessageBox.Show("É necessário preencher o campo ID para consultar");
            }            
        }
    }
}
