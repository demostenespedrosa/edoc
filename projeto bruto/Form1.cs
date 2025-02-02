using E_Doc;

namespace e_doc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCriarDocumento_Click(object sender, EventArgs e)
        {
            // Cria a instância do FormDocumento e exibe como modal
            using (FormDocumento formDocumento = new FormDocumento())
            {
                formDocumento.ShowDialog();  // Exibe de forma modal
            }

            this.Hide(); // Oculta o Form1 após o fechamento do FormDocumento
        }


    }
}
