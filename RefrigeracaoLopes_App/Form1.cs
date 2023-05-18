using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RefrigeracaoLopes_App
{
    public partial class Principal : Form
    {

        public static CultureInfo culture = new CultureInfo("pt-BR");
        public static String cpf = "";
        public static String nome = "";
        public static String email = "";
        public static String telefone = "";
        public static String servico = "";
        public static String endereco = "";
        public static DateTime dataNasc;
       
        public static int id;

        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'refrigeracaoDBDataSet2.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter2.Fill(this.refrigeracaoDBDataSet2.Clientes);





        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.setID(int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
            
            cliente.setCPF(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            cliente.setEmail(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            cliente.setNome(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            cliente.setTelefone(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            cliente.setEndereco(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            cliente.setDataNsc(DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString()));

            
            cpf = cliente.getCpf();
            nome = cliente.getNome();
            email = cliente.getEmail();
            telefone = cliente.getTelefone();    
            endereco = cliente.getEndereco();
            id = cliente.getId();
            dataNasc = cliente.getDataNsc();

            Form2 formDetalhes = new Form2();
            //passar informações pros detalhes
            
            formDetalhes.ShowDialog();

          

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            RegistroCliente registro = new RegistroCliente();
            registro.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button pesquisar
            
            mecanismoDeBusca mecanismoDeBusca = new mecanismoDeBusca();
            mecanismoDeBusca.Show();

        }

        private void clienteArea_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientesTableAdapter2.Fill(this.refrigeracaoDBDataSet2.Clientes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["RefrigeracaoLopes_App.Properties.Settings.refrigeracaoDB"].ConnectionString;
            String pesquisa = textPesq.Text;
            String query = String.Format("SELECT * FROM Clientes WHERE CONCAT([ID],[CPF_CNPJ], [EMAIL], [NOME], [TELEFONE], [ENDEREÇO], [DATA_NSC]) LIKE '%{0}%'", pesquisa);
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridViewPesqToService.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void textPesq_KeyPress(object sender, KeyPressEventArgs e)
        {
            button2.PerformClick();
        }

        private void dataGridViewPesqToService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.setID(int.Parse(dataGridViewPesqToService.Rows[e.RowIndex].Cells[0].Value.ToString()));

            cliente.setCPF(dataGridViewPesqToService.Rows[e.RowIndex].Cells[1].Value.ToString());
            cliente.setEmail(dataGridViewPesqToService.Rows[e.RowIndex].Cells[2].Value.ToString());
            cliente.setNome(dataGridViewPesqToService.Rows[e.RowIndex].Cells[3].Value.ToString());
            cliente.setTelefone(dataGridViewPesqToService.Rows[e.RowIndex].Cells[4].Value.ToString());
            cliente.setEndereco(dataGridViewPesqToService.Rows[e.RowIndex].Cells[5].Value.ToString());
            cliente.setDataNsc(DateTime.Parse(dataGridViewPesqToService.Rows[e.RowIndex].Cells[6].Value.ToString()));


            cpf = cliente.getCpf();
            nome = cliente.getNome();
            email = cliente.getEmail();
            telefone = cliente.getTelefone();
            endereco = cliente.getEndereco();
            id = cliente.getId();
            dataNasc = cliente.getDataNsc();


            NovoServico novoServico = new NovoServico();

            novoServico.ShowDialog();


        }
    }
}
