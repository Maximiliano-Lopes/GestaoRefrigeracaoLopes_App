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

            String connectionString = ConfigurationManager.ConnectionStrings["RefrigeracaoLopes_App.Properties.Settings.refrigeracaoDB"].ConnectionString;

            DateTime dataNscNew = DateTime.Parse(datePickArea.Text.ToString());

                Cliente cliente = new Cliente( inputNCPF.Text.ToString(),  inputNNome.Text.ToString(), inputNEmail.Text.ToString(), inputNTelefone.Text.ToString(), inputNEnd.Text.ToString(), dataNscNew, DateTime.Now);
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Construa a consulta SQL para verificar se o cliente existe
                    string query = "SELECT COUNT(*) FROM Clientes WHERE CPF_CNPJ = @Cliente";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Cliente", cliente.getCpf());

                    int count = (int)command.ExecuteScalar();
                    connection.Close();

                    if (count > 0)
                    {
                        Console.WriteLine("O cliente com este CPF/CNPJ já foi registrado.");
                    }
                    else
                    {
                        try
                        {

                            string cmdString = "INSERT INTO Clientes ([CPF_CNPJ], [EMAIL], [NOME], [TELEFONE], [ENDEREÇO], [DATA_NSC], [DATA_CRIACAO]) ";
                            cmdString += "VALUES (@CPF_CNPJ, @EMAIL, @NOME, @TELEFONE, @ENDERECO, @DATA_NSC, @DATA_CRIACAO)";

                            using (SqlConnection connectionIns = new SqlConnection(connectionString))
                            {

                                using (SqlCommand commandInsert = new SqlCommand(cmdString, connectionIns))
                                {

                                   commandInsert.Connection.Open();


                                   commandInsert.Parameters.AddWithValue("@CPF_CNPJ", cliente.getCpf());
                                   commandInsert.Parameters.AddWithValue("@EMAIL", cliente.getEmail());
                                   commandInsert.Parameters.AddWithValue("@NOME", cliente.getNome());
                                   commandInsert.Parameters.AddWithValue("@TELEFONE", cliente.getTelefone());
                                   commandInsert.Parameters.AddWithValue("@ENDERECO", cliente.getEndereco());
                                   commandInsert.Parameters.AddWithValue("@DATA_NSC", cliente.getDataNsc());
                                   commandInsert.Parameters.AddWithValue("@DATA_CRIACAO", DateTime.Now);

                                    int result = commandInsert.ExecuteNonQuery();

                                    connectionIns.Close();

                                    // Check Error
                                    if (result < 0)
                                    {
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
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }

        private void datePickArea_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RegistroCliente_Load(object sender, EventArgs e)
        {
            datePickArea.Value = DateTime.Now;
        }
    }
}
