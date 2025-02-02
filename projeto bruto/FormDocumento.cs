using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

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
            // Criar um caminho para salvar o arquivo
            string caminhoArquivo = "DocumentoFiscal.txt";

            // Criar o conteúdo do arquivo com os dados preenchidos
            string conteudo = $"Nome do Cliente: {txtNomeCliente.Text}\n" +
                              $"CNPJ do Cliente: {txtCnpjCliente.Text}\n" +
                              $"Endereço: {txtEndereco.Text}\n" +
                              $"Telefone do Cliente: {txtTelefoneCliente.Text}\n" +
                              $"Serviço/Produto: {txtServicoProduto.Text}\n" +
                              $"Valor: R$ {txtValor.Text}\n" +
                              $"Data: {txtData.Text}\n" +
                              $"Número do Orçamento: {txtNumeroOrcamento.Text}\n" +
                              $"Nome da Empresa: {txtNomeEmpresa.Text}\n" +
                              $"Telefone da Empresa: {txtTelefoneEmpresa.Text}\n";

            // Escrever os dados no arquivo TXT
            File.WriteAllText(caminhoArquivo, conteudo);

            // Mostrar uma mensagem de sucesso
            MessageBox.Show("Arquivo TXT criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Abrir o arquivo automaticamente
            System.Diagnostics.Process.Start("notepad.exe", caminhoArquivo);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
