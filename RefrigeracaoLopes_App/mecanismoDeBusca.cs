using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeracaoLopes_App
{
    public partial class mecanismoDeBusca : Form
    {
        public mecanismoDeBusca()
        {
            InitializeComponent();
        }

        private void mecanismoDeBusca_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["RefrigeracaoLopes_App.Properties.Settings.refrigeracaoDB"].ConnectionString;
            String pesquisa = textPesq.Text;
            String query = String.Format("SELECT * FROM Clientes WHERE CONCAT([ID],[CPF_CNPJ], [EMAIL], [NOME], [TELEFONE], [ENDEREÇO], [DATA_NSC]) LIKE '%{0}%'", pesquisa);
            try {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridViewPesq.DataSource = table;
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
             
     }

        private void relatórioDaSemanaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textPesq_TextChanged(object sender, EventArgs e)
        {
            button1.PerformClick();
        }
    }
}
