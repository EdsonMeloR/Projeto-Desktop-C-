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
    public partial class FrmClienteCadastrar : Form
    {
        public FrmClienteCadastrar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            try
            {
                c.InserirCliente(txtRazaoSocial.Text, txtCnpj.Text, txtEmail.Text, txtInscricaoEstadual.Text, txtSenha.Text, txtTelefone.Text, txtNomeContato.Text);
                if (c.Id > 0)
                {
                    txtIdCliente.Text = c.Id.ToString();
                    FrmEnderecos frm = new FrmEnderecos();
                    frm.Show();
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }            
        }        

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }             

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.ConsultarClienteCnpj(txtCnpj.Text);
            txtIdCliente.Text = c.Id.ToString();
            txtCnpj.Text = c.Cnpj.ToString();
            txtEmail.Text = c.Email.ToString();
            txtInscricaoEstadual.Text = c.InscricaoEstadual.ToString();
            txtNomeContato.Text = c.NomeContato.ToString();
            txtRazaoSocial.Text = c.RazaoSocial.ToString();
            txtSenha.Text = c.Senha.ToString();
            txtTelefone.Text = c.Telefone.ToString();
        }

        private void btnCadastrarEndereco_Click(object sender, EventArgs e)
        {
            FrmEnderecos frm = new FrmEnderecos();
            frm.Show();
        }
    }
}
