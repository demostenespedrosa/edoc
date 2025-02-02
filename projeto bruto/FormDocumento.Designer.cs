namespace E_Doc
{
    partial class FormDocumento
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtNomeCliente = new TextBox();
            label3 = new Label();
            txtCnpjCliente = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtValor = new TextBox();
            txtEndereco = new TextBox();
            txtData = new TextBox();
            txtNumeroOrcamento = new TextBox();
            txtNomeEmpresa = new TextBox();
            txtTelefoneCliente = new TextBox();
            txtTelefoneEmpresa = new TextBox();
            txtServicoProduto = new TextBox();
            btnMostrarTxt = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(350, 10);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 21;
            label1.Text = "E-DOC";
            // 
            // label2
            // 
            label2.Location = new Point(50, 50);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 20;
            label2.Text = "Nome do Cliente:";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(250, 47);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(200, 23);
            txtNomeCliente.TabIndex = 19;
            // 
            // label3
            // 
            label3.Location = new Point(50, 80);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 18;
            label3.Text = "CNPJ do Cliente:";
            // 
            // txtCnpjCliente
            // 
            txtCnpjCliente.Location = new Point(250, 80);
            txtCnpjCliente.Name = "txtCnpjCliente";
            txtCnpjCliente.Size = new Size(200, 23);
            txtCnpjCliente.TabIndex = 17;
            // 
            // label4
            // 
            label4.Location = new Point(50, 110);
            label4.Name = "label4";
            label4.Size = new Size(166, 23);
            label4.TabIndex = 16;
            label4.Text = "Valor do Serviço/Produto:";
            // 
            // label5
            // 
            label5.Location = new Point(50, 140);
            label5.Name = "label5";
            label5.Size = new Size(154, 23);
            label5.TabIndex = 15;
            label5.Text = "Endereço/Cidade/Bairro:";
            // 
            // label6
            // 
            label6.Location = new Point(50, 170);
            label6.Name = "label6";
            label6.Size = new Size(140, 23);
            label6.TabIndex = 14;
            label6.Text = "Data do Serviço/Venda:";
            // 
            // label7
            // 
            label7.Location = new Point(50, 200);
            label7.Name = "label7";
            label7.Size = new Size(154, 23);
            label7.TabIndex = 13;
            label7.Text = "Número do Orçamento:";
            // 
            // label8
            // 
            label8.Location = new Point(50, 230);
            label8.Name = "label8";
            label8.Size = new Size(140, 23);
            label8.TabIndex = 12;
            label8.Text = "Nome da Empresa:";
            // 
            // label9
            // 
            label9.Location = new Point(50, 260);
            label9.Name = "label9";
            label9.Size = new Size(166, 23);
            label9.TabIndex = 11;
            label9.Text = "Telefone do Cliente:";
            // 
            // label10
            // 
            label10.Location = new Point(50, 290);
            label10.Name = "label10";
            label10.Size = new Size(154, 23);
            label10.TabIndex = 10;
            label10.Text = "Telefone da Empresa:";
            // 
            // label11
            // 
            label11.Location = new Point(50, 320);
            label11.Name = "label11";
            label11.Size = new Size(166, 23);
            label11.TabIndex = 9;
            label11.Text = "Serviço Realizado/Produto:";
            label11.Click += label11_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(250, 110);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(200, 23);
            txtValor.TabIndex = 8;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(250, 140);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(200, 23);
            txtEndereco.TabIndex = 7;
            // 
            // txtData
            // 
            txtData.Location = new Point(250, 170);
            txtData.Name = "txtData";
            txtData.Size = new Size(200, 23);
            txtData.TabIndex = 6;
            // 
            // txtNumeroOrcamento
            // 
            txtNumeroOrcamento.Location = new Point(250, 200);
            txtNumeroOrcamento.Name = "txtNumeroOrcamento";
            txtNumeroOrcamento.Size = new Size(200, 23);
            txtNumeroOrcamento.TabIndex = 5;
            // 
            // txtNomeEmpresa
            // 
            txtNomeEmpresa.Location = new Point(250, 230);
            txtNomeEmpresa.Name = "txtNomeEmpresa";
            txtNomeEmpresa.Size = new Size(200, 23);
            txtNomeEmpresa.TabIndex = 4;
            // 
            // txtTelefoneCliente
            // 
            txtTelefoneCliente.Location = new Point(250, 260);
            txtTelefoneCliente.Name = "txtTelefoneCliente";
            txtTelefoneCliente.Size = new Size(200, 23);
            txtTelefoneCliente.TabIndex = 3;
            // 
            // txtTelefoneEmpresa
            // 
            txtTelefoneEmpresa.Location = new Point(250, 290);
            txtTelefoneEmpresa.Name = "txtTelefoneEmpresa";
            txtTelefoneEmpresa.Size = new Size(200, 23);
            txtTelefoneEmpresa.TabIndex = 2;
            // 
            // txtServicoProduto
            // 
            txtServicoProduto.Location = new Point(250, 320);
            txtServicoProduto.Name = "txtServicoProduto";
            txtServicoProduto.Size = new Size(200, 23);
            txtServicoProduto.TabIndex = 1;
            // 
            // btnMostrarTxt
            // 
            btnMostrarTxt.Location = new Point(350, 370);
            btnMostrarTxt.Name = "btnMostrarTxt";
            btnMostrarTxt.Size = new Size(100, 30);
            btnMostrarTxt.TabIndex = 0;
            btnMostrarTxt.Text = "Mostrar TXT";
            btnMostrarTxt.Click += btnMostrarTxt_Click;
            // 
            // FormDocumento
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(btnMostrarTxt);
            Controls.Add(txtServicoProduto);
            Controls.Add(txtTelefoneEmpresa);
            Controls.Add(txtTelefoneCliente);
            Controls.Add(txtNomeEmpresa);
            Controls.Add(txtNumeroOrcamento);
            Controls.Add(txtData);
            Controls.Add(txtEndereco);
            Controls.Add(txtValor);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtCnpjCliente);
            Controls.Add(label3);
            Controls.Add(txtNomeCliente);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDocumento";
            Text = "Documento Fiscal";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11;
        private System.Windows.Forms.TextBox txtNomeCliente, txtCnpjCliente, txtValor, txtEndereco, txtData, txtNumeroOrcamento, txtNomeEmpresa, txtTelefoneCliente, txtTelefoneEmpresa, txtServicoProduto;
        private System.Windows.Forms.Button btnMostrarTxt;
    }
}
