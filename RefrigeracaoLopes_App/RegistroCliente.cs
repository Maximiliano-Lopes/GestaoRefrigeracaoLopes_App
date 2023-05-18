using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RefrigeracaoLopes_App
{
    public partial class RegistroCliente : Form
    {
        CultureInfo culture = new CultureInfo("pt-BR");


        public RegistroCliente()
        {
            InitializeComponent();
        }

        private void btn_cancelarAlt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_confirmarAlt_Click(object sender, EventArgs e)
        {

            try {

                DateTime dataNscNew = DateTime.Parse(datePickArea.Text.ToString());

                Cliente cliente = new Cliente( inputNCPF.Text.ToString(),  inputNNome.Text.ToString(), inputNEmail.Text.ToString(), inputNTelefone.Text.ToString(), inputNEnd.Text.ToString(), dataNscNew);

                Console.WriteLine(cliente.ToString());
                
                try
                {
                    String connectionString = ConfigurationManager.ConnectionStrings["RefrigeracaoLopes_App.Properties.Settings.refrigeracaoDB"].ConnectionString;

                    string cmdString = "INSERT INTO Clientes ([CPF_CNPJ], [EMAIL], [NOME], [TELEFONE], [ENDEREÇO], [DATA_NSC]) ";
                           cmdString += "VALUES (@CPF_CNPJ, @EMAIL, @NOME, @TELEFONE, @ENDERECO, @DATA_NSC)";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        
                        using (SqlCommand command = new SqlCommand(cmdString, connection)) {

                            command.Connection.Open();
                           

                            command.Parameters.AddWithValue("@CPF_CNPJ", cliente.getCpf());
                            command.Parameters.AddWithValue("@EMAIL", cliente.getEmail());
                            command.Parameters.AddWithValue("@NOME", cliente.getNome());
                            command.Parameters.AddWithValue("@TELEFONE", cliente.getTelefone());
                            command.Parameters.AddWithValue("@ENDERECO", cliente.getEndereco());
                            command.Parameters.AddWithValue("@DATA_NSC", cliente.getDataNsc());

                            
                            int result = command.ExecuteNonQuery();
                            


                            // Check Error
                            if (result < 0) { 
                                MessageBox.Show("Houve um erro ao Criar o cliente, tente novamente!");
                            }
                            else
                            {
                                MessageBox.Show("Cliente criado com sucesso!");
                                this.Close();
                            }

                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            catch (Exception ex){ 
                MessageBox.Show(ex.ToString());
            }

        }

        private void datePickArea_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
