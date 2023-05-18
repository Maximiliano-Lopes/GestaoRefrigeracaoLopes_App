using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeracaoLopes_App
{
    public partial class DetalhesServico : Form
    {
        public DetalhesServico()
        {
            InitializeComponent();
        }

        private void DetalhesServico_Load(object sender, EventArgs e)
        {
            

            if (Form2.cpf_cnpj.ToString() != "" && Form2.cpf_cnpj.ToString() != " ")
            {
                idServico_Place.Text = Regex.Replace(Form2.id_Servico.ToString(), @"\s+", "");
                inputCPF.Text = Regex.Replace(Form2.cpf_cnpj.ToString(), @"\s+", "");
                idPagamento_Place.Text = Form2.id_Pagamento.ToString();


                String connectionString = ConfigurationManager.ConnectionStrings["RefrigeracaoLopes_App.Properties.Settings.refrigeracaoDB"].ConnectionString;
                
                try
                {
                    string queryString = "SELECT Cliente.ID, Cliente.NOME, Cliente.EMAIL, Cliente.ENDEREÇO, Cliente.TELEFONE, Servicos.DATA_ENTRADA, Servicos.DATA_TERMINO, Servicos.ESTADO, Servicos.NUMERO_ORÇAMENTO, Servicos.INFO, Servicos.PRECO, Pagamento.ESTADO, Pagamento.PRODUTO FROM [dbo].[Serviços] as Servicos, [dbo].[Clientes] as Cliente, [dbo].[Pagamento] AS Pagamento ";
                    queryString += "WHERE Servicos.CPF_CNPJ = '" + Regex.Replace(Form2.cpf_cnpj.ToString(), @"\s+", "").ToString() + "' and Cliente.CPF_CNPJ = '" + Regex.Replace(Form2.cpf_cnpj.ToString(), @"\s+", "").ToString() + "' and Servicos.ID = " + Form2.id_Servico + " and Pagamento.ID = Servicos.PAGAMENTO_ID;";



                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(queryString, connection);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                           
                            while (reader.Read())
                            {
                                try
                                {

                                    //0                1              2            3                4                5                        6
                                    //Cliente.ID, Cliente.NOME, Cliente.EMAIL, Cliente.ENDEREÇO, Cliente.TELEFONE, Servicos.DATA_ENTRADA, Servicos.DATA_TERMINO,
                                    //        7                     8                   9              10               11           12
                                    //Servicos.ESTADO, Servicos.NUMERO_ORÇAMENTO, Servicos.INFO, Servicos.PRECO, Pagamento.ESTADO, Pagamento.PRODUTO

                                    
                                    
                                    idCliente_Place.Text = reader.GetInt32(0).ToString();
                                    inputNome.Text = reader.GetString(1);
                                    inputEmail.Text = reader.GetString(2);
                                    inputEnd.Text = reader.GetString(3);
                                    inputTelefone.Text = reader.GetString(4);
                                    datePickAreaEntrada.Value = reader.GetDateTime(5);
                                    dateTimePickerTermino.Value = reader.GetDateTime(6);
                                    listEstadoServico.SelectedIndex = reader.GetInt32(7);
                                    numericUpDownOrcamento.Value = reader.GetInt32(8);
                                    textBoxDescricaoProduto.Text = reader.GetString(9);
                                    numericUpDownPreco.Value = reader.GetDecimal(10);
                                    listEstadoPagamento.SelectedIndex = reader.GetInt32(11);
                                    textBoxNomeProduto.Text = reader.GetString(12);

                                }
                                catch (Exception ex)
                                {
                                    connection.Close();
                                    Console.WriteLine(ex.StackTrace);
                                }
                            }
                            
                            connection.Close();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }
            else
            {
                this.Close();
            }

        }

        private void datePickAreaEntrada_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
