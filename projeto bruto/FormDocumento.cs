using System;
using System.IO;
using System.Windows.Forms;

namespace E_Doc
{
    public partial class FormDocumento : Form
    {
        public FormDocumento()
        {
            InitializeComponent();
        }

        private void btnMostrarTxt_Click(object sender, EventArgs e)
        {
            string caminhoArquivo = "DocumentoFiscal.txt";
            SalvarArquivo(caminhoArquivo);

            // Verifique se o arquivo existe antes de tentar abrir
            if (File.Exists(caminhoArquivo))
            {
                try
                {
                    // Tenta abrir o arquivo com o Notepad (Bloco de Notas)
                    System.Diagnostics.Process.Start("notepad.exe", caminhoArquivo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao tentar abrir o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Arquivo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGerarNovoArquivo_Click(object sender, EventArgs e)
        {
            // Limpar os campos de texto
            txtNomeCliente.Clear();
            txtCnpjCliente.Clear();
            txtValor.Clear();
            txtEndereco.Clear();
            txtData.Clear();
            txtNumeroOrcamento.Clear();
            txtNomeEmpresa.Clear();
            txtTelefoneCliente.Clear();
            txtTelefoneEmpresa.Clear();
            txtServicoProduto.Clear();
            txtCNPJEmpresa.Clear();
        }

        private void SalvarArquivo(string caminhoArquivo)
        {
            string conteudo = $"Nome do Cliente: {txtNomeCliente.Text}\n" +
                              $"CNPJ do Cliente: {txtCnpjCliente.Text}\n" +
                              $"Endereço: {txtEndereco.Text}\n" +
                              $"Telefone do Cliente: {txtTelefoneCliente.Text}\n" +
                              $"Serviço/Produto: {txtServicoProduto.Text}\n" +
                              $"Valor: R$ {txtValor.Text}\n" +
                              $"Data: {txtData.Text}\n" +
                              $"Número do Orçamento: {txtNumeroOrcamento.Text}\n" +
                              $"Nome da Empresa: {txtNomeEmpresa.Text}\n" +
                              $"CNPJ da Empresa: {txtCNPJEmpresa.Text}\n" +
                              $"Telefone da Empresa: {txtTelefoneEmpresa.Text}\n";

            try
            {
                // Salva o conteúdo no arquivo
                File.WriteAllText(caminhoArquivo, conteudo);
                MessageBox.Show($"Arquivo criado com sucesso:\n{caminhoArquivo}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            // Limpa os campos para um novo preenchimento
            txtNomeCliente.Text = "";
            txtCnpjCliente.Text = "";
            txtEndereco.Text = "";
            txtTelefoneCliente.Text = "";
            txtServicoProduto.Text = "";
            txtValor.Text = "";
            txtData.Text = "";
            txtNumeroOrcamento.Text = "";
            txtNomeEmpresa.Text = "";
            txtCNPJEmpresa.Text = "";
            txtTelefoneEmpresa.Text = "";
        }

        private void label11_Click(object sender, EventArgs e)
        {
            // Evento vazio, pode ser removido se não for necessário.
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
