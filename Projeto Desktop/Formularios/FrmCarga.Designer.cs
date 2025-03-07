﻿namespace Projeto_Desktop.Formularios
{
    partial class FrmCarga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarga));
            this.txtIdCarga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInserirCarga = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDetalhes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grbCarga = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mskValorProduto = new System.Windows.Forms.MaskedTextBox();
            this.mskComprimento = new System.Windows.Forms.MaskedTextBox();
            this.mskAltura = new System.Windows.Forms.MaskedTextBox();
            this.mskLargura = new System.Windows.Forms.MaskedTextBox();
            this.mskPeso = new System.Windows.Forms.MaskedTextBox();
            this.btnAlterarCarga = new System.Windows.Forms.Button();
            this.btnConsultarCargas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTiposCargas = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grpListaCargasPedido = new System.Windows.Forms.GroupBox();
            this.dgvCargasPedido = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grbCarga.SuspendLayout();
            this.grpListaCargasPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargasPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdCarga
            // 
            this.txtIdCarga.Location = new System.Drawing.Point(9, 40);
            this.txtIdCarga.Name = "txtIdCarga";
            this.txtIdCarga.Size = new System.Drawing.Size(135, 20);
            this.txtIdCarga.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Carga";
            // 
            // btnInserirCarga
            // 
            this.btnInserirCarga.Location = new System.Drawing.Point(213, 201);
            this.btnInserirCarga.Name = "btnInserirCarga";
            this.btnInserirCarga.Size = new System.Drawing.Size(104, 23);
            this.btnInserirCarga.TabIndex = 2;
            this.btnInserirCarga.Text = "Inserir Carga";
            this.btnInserirCarga.UseVisualStyleBackColor = true;
            this.btnInserirCarga.Click += new System.EventHandler(this.btnInserirCarga_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Largura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Altura";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Comprimento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Detalhes Produto";
            // 
            // txtDetalhes
            // 
            this.txtDetalhes.Location = new System.Drawing.Point(213, 85);
            this.txtDetalhes.Multiline = true;
            this.txtDetalhes.Name = "txtDetalhes";
            this.txtDetalhes.Size = new System.Drawing.Size(276, 34);
            this.txtDetalhes.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Peso";
            // 
            // grbCarga
            // 
            this.grbCarga.Controls.Add(this.label16);
            this.grbCarga.Controls.Add(this.txtQuantidade);
            this.grbCarga.Controls.Add(this.label17);
            this.grbCarga.Controls.Add(this.txtNomeProduto);
            this.grbCarga.Controls.Add(this.label15);
            this.grbCarga.Controls.Add(this.label14);
            this.grbCarga.Controls.Add(this.label13);
            this.grbCarga.Controls.Add(this.label12);
            this.grbCarga.Controls.Add(this.label11);
            this.grbCarga.Controls.Add(this.label4);
            this.grbCarga.Controls.Add(this.mskValorProduto);
            this.grbCarga.Controls.Add(this.mskComprimento);
            this.grbCarga.Controls.Add(this.mskAltura);
            this.grbCarga.Controls.Add(this.mskLargura);
            this.grbCarga.Controls.Add(this.mskPeso);
            this.grbCarga.Controls.Add(this.btnAlterarCarga);
            this.grbCarga.Controls.Add(this.btnConsultarCargas);
            this.grbCarga.Controls.Add(this.label3);
            this.grbCarga.Controls.Add(this.cmbTiposCargas);
            this.grbCarga.Controls.Add(this.label10);
            this.grbCarga.Controls.Add(this.btnInserirCarga);
            this.grbCarga.Controls.Add(this.label1);
            this.grbCarga.Controls.Add(this.label8);
            this.grbCarga.Controls.Add(this.label9);
            this.grbCarga.Controls.Add(this.txtDetalhes);
            this.grbCarga.Controls.Add(this.txtIdCarga);
            this.grbCarga.Controls.Add(this.label5);
            this.grbCarga.Controls.Add(this.label7);
            this.grbCarga.Controls.Add(this.label6);
            this.grbCarga.Location = new System.Drawing.Point(12, 58);
            this.grbCarga.Name = "grbCarga";
            this.grbCarga.Size = new System.Drawing.Size(561, 242);
            this.grbCarga.TabIndex = 19;
            this.grbCarga.TabStop = false;
            this.grbCarga.Text = "Inserir Cargas";
            this.grbCarga.Enter += new System.EventHandler(this.grbCarga_Enter);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(498, 165);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 13);
            this.label16.TabIndex = 37;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(213, 136);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(135, 20);
            this.txtQuantidade.TabIndex = 36;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(210, 120);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Quantidade";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(213, 40);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(141, 20);
            this.txtNomeProduto.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(210, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Nome Produto";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(354, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(150, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "M";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(150, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "M";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(150, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "M";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "KG";
            // 
            // mskValorProduto
            // 
            this.mskValorProduto.Location = new System.Drawing.Point(213, 175);
            this.mskValorProduto.Name = "mskValorProduto";
            this.mskValorProduto.Size = new System.Drawing.Size(135, 20);
            this.mskValorProduto.TabIndex = 29;
            this.mskValorProduto.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskValorProduto_MaskInputRejected);
            // 
            // mskComprimento
            // 
            this.mskComprimento.Location = new System.Drawing.Point(9, 198);
            this.mskComprimento.Name = "mskComprimento";
            this.mskComprimento.Size = new System.Drawing.Size(135, 20);
            this.mskComprimento.TabIndex = 28;
            // 
            // mskAltura
            // 
            this.mskAltura.Location = new System.Drawing.Point(9, 117);
            this.mskAltura.Name = "mskAltura";
            this.mskAltura.Size = new System.Drawing.Size(135, 20);
            this.mskAltura.TabIndex = 27;
            // 
            // mskLargura
            // 
            this.mskLargura.Location = new System.Drawing.Point(9, 156);
            this.mskLargura.Name = "mskLargura";
            this.mskLargura.Size = new System.Drawing.Size(135, 20);
            this.mskLargura.TabIndex = 26;
            // 
            // mskPeso
            // 
            this.mskPeso.Location = new System.Drawing.Point(9, 79);
            this.mskPeso.Name = "mskPeso";
            this.mskPeso.Size = new System.Drawing.Size(135, 20);
            this.mskPeso.TabIndex = 25;
            // 
            // btnAlterarCarga
            // 
            this.btnAlterarCarga.Location = new System.Drawing.Point(433, 201);
            this.btnAlterarCarga.Name = "btnAlterarCarga";
            this.btnAlterarCarga.Size = new System.Drawing.Size(104, 23);
            this.btnAlterarCarga.TabIndex = 24;
            this.btnAlterarCarga.Text = "Alterar Carga";
            this.btnAlterarCarga.UseVisualStyleBackColor = true;
            this.btnAlterarCarga.Click += new System.EventHandler(this.btnAlterarCarga_Click);
            // 
            // btnConsultarCargas
            // 
            this.btnConsultarCargas.Location = new System.Drawing.Point(323, 201);
            this.btnConsultarCargas.Name = "btnConsultarCargas";
            this.btnConsultarCargas.Size = new System.Drawing.Size(104, 23);
            this.btnConsultarCargas.TabIndex = 23;
            this.btnConsultarCargas.Text = "Consultar Carga";
            this.btnConsultarCargas.UseVisualStyleBackColor = true;
            this.btnConsultarCargas.Click += new System.EventHandler(this.btnConsultarCargas_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tipos de Cargas";
            // 
            // cmbTiposCargas
            // 
            this.cmbTiposCargas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTiposCargas.FormattingEnabled = true;
            this.cmbTiposCargas.Location = new System.Drawing.Point(357, 40);
            this.cmbTiposCargas.Name = "cmbTiposCargas";
            this.cmbTiposCargas.Size = new System.Drawing.Size(132, 21);
            this.cmbTiposCargas.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(210, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Valor Produto";
            // 
            // grpListaCargasPedido
            // 
            this.grpListaCargasPedido.Controls.Add(this.dgvCargasPedido);
            this.grpListaCargasPedido.Location = new System.Drawing.Point(12, 306);
            this.grpListaCargasPedido.Name = "grpListaCargasPedido";
            this.grpListaCargasPedido.Size = new System.Drawing.Size(561, 237);
            this.grpListaCargasPedido.TabIndex = 21;
            this.grpListaCargasPedido.TabStop = false;
            this.grpListaCargasPedido.Text = "Cargas Pedidos";
            // 
            // dgvCargasPedido
            // 
            this.dgvCargasPedido.AllowUserToOrderColumns = true;
            this.dgvCargasPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargasPedido.Location = new System.Drawing.Point(6, 19);
            this.dgvCargasPedido.Name = "dgvCargasPedido";
            this.dgvCargasPedido.RowHeadersVisible = false;
            this.dgvCargasPedido.Size = new System.Drawing.Size(549, 212);
            this.dgvCargasPedido.TabIndex = 5;
            this.dgvCargasPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCargasPedido_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 35);
            this.button1.TabIndex = 35;
            this.button1.Text = "Gerar Nota Transporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Enabled = false;
            this.txtIdPedido.Location = new System.Drawing.Point(18, 29);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(138, 20);
            this.txtIdPedido.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "ID Pedido";
            // 
            // FrmCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 594);
            this.Controls.Add(this.txtIdPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpListaCargasPedido);
            this.Controls.Add(this.grbCarga);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Cargas";
            this.Load += new System.EventHandler(this.FrmCarga_Load);
            this.grbCarga.ResumeLayout(false);
            this.grbCarga.PerformLayout();
            this.grpListaCargasPedido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargasPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdCarga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInserirCarga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDetalhes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grbCarga;
        private System.Windows.Forms.Button btnAlterarCarga;
        private System.Windows.Forms.Button btnConsultarCargas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTiposCargas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grpListaCargasPedido;
        private System.Windows.Forms.DataGridView dgvCargasPedido;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskValorProduto;
        private System.Windows.Forms.MaskedTextBox mskComprimento;
        private System.Windows.Forms.MaskedTextBox mskAltura;
        private System.Windows.Forms.MaskedTextBox mskLargura;
        private System.Windows.Forms.MaskedTextBox mskPeso;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox txtQuantidade;
        private System.Windows.Forms.Label label17;
    }
}