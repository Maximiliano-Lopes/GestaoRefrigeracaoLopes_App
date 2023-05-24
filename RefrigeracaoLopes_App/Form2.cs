using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;



namespace RefrigeracaoLopes_App
{
   
    public partial class Form2 : Form
    {
        String inputCPFAntigo = "";
        DateTime dataNascAntiga;
        public static int id_Servico;
        public static String cpf_cnpj;
        public static int id_Pagamento;



        //FORM DE DETALHES DE CLIENTES
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            inputCPFAntigo = Principal.cpf;
            inputCPF.Text = Principal.cpf;
            inputNome.Text = Principal.nome;
            inputEmail.Text = Principal.email;
            inputTelefone.Text = Principal.telefone;
            inputEnd.Text = Principal.endereco;
            id_Place.Text = Principal.id.ToString();

            dataNascAntiga = Principal.dataNasc;
            datePickAreaNasc.Value = Principal.dataNasc;
            datePickAreaNasc.Enabled = false;
            dateTimeClienteDesde.Value = Principal.dataCriacao;

            String connectionString = ConfigurationManager.ConnectionStrings["RefrigeracaoLopes_App.Properties.Settings.refrigeracaoDB"].ConnectionString;
            try
            {
                string queryString = "SELECT * FROM Serviços WHERE CPF_CNPJ = '" + Principal.cpf + "' ORDER BY ESTADO;";
                using (SqlConnection connection = new SqlConnection( 
                           connectionString))
                {
                    SqlCommand command = new SqlCommand(
                        queryString, connection);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.IsClosed)
                        {
                            while (reader.Read())
                            {
                                try
                                {

                                    //Pegar a informação do serviço! Verificar isso 
                                    //0       1          2           3          4         5     6        **7           **8
                                    //id , CPF_CNPJ, DATA_ENTRADA, PRECO, PAGAMENTO_ID, ESTADO, INFO, DATA_TERMINO, NUEMERO_ORÇAMENTO


                                    String row = reader.GetInt32(0) + " - " + reader.GetString(1) + " - " + reader.GetDateTime(2) + " - " + reader.GetDecimal(3) + " - " + reader.GetInt32(4) + " - " + reader.GetInt32(5) + " - " + reader.GetString(6);

                                    listServicos.Items.Add(row);




                                }
                                catch (Exception ex)
                                {
                                    
                                    Console.WriteLine(ex.ToString());
                                }
                            }
                            connection.Close();
                        }
                    }
                }
            }
            catch (SqlException ex){
                Console.WriteLine(ex.StackTrace);
            }
        }
            
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listServicos.SelectedItem != null) { 
                string[] listaServico = listServicos.SelectedItem.ToString().Split('-');
            

                id_Servico = int.Parse(listaServico[0]);
                cpf_cnpj = listaServico[1];
                id_Pagamento = int.Parse(listaServico[4]);

                DetalhesServico detalhesServico = new DetalhesServico();

                detalhesServico.Show();
            }


        }

        private void btn_editarInfo_Click(object sender, EventArgs e)
        {
            


            inputNome.ReadOnly = false;
            inputEmail.ReadOnly = false;
            inputTelefone.ReadOnly = false;
            inputEnd.ReadOnly = false;
            datePickAreaNasc.Enabled = true;
            btn_confirmarAlt.Visible = true;
            btn_cancelarAlt.Visible = true;

            

            

        }

        private void btn_confirmarAlt_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(inputCPF.Text.ToString(), inputNome.Text.ToString(), inputEmail.Text.ToString(), inputTelefone.Text.ToString(), inputEnd.Text.ToString(), DateTime.Parse(datePickAreaNasc.Text), Principal.dataCriacao);



            int resCompareDates = DateTime.Compare( DateTime.Parse(datePickAreaNasc.Text), dataNascAntiga);

            if (inputCPF.Text != Principal.cpf | inputNome.Text != Principal.nome | inputEmail.Text != Principal.email | inputTelefone.Text != Principal.telefone | inputEnd.Text != Principal.endereco | resCompareDates != 0)
            {

                try
                {
                    String connectionString = ConfigurationManager.ConnectionStrings["RefrigeracaoLopes_App.Properties.Settings.refrigeracaoDB"].ConnectionString;

                    string cmdString = "UPDATE Clientes SET [CPF_CNPJ] = @CPF_CNPJ, [EMAIL] = @EMAIL,[NOME] = @NOME,[TELEFONE] = @TELEFONE,[ENDEREÇO] = @ENDERECO,[DATA_NSC] = @DATA_NSC " +
                        "WHERE CPF_CNPJ = @CPF_CNPJ_ANTIGO;";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {

                        using (SqlCommand command = new SqlCommand(cmdString, connection))
                        {



                                
                            command.Parameters.AddWithValue("@CPF_CNPJ_ANTIGO", inputCPFAntigo);
                            command.Parameters.AddWithValue("@CPF_CNPJ", cliente.getCpf());
                            command.Parameters.AddWithValue("@EMAIL", cliente.getEmail());
                            command.Parameters.AddWithValue("@NOME", cliente.getNome());
                            command.Parameters.AddWithValue("@TELEFONE", cliente.getTelefone());
                            command.Parameters.AddWithValue("@ENDERECO", cliente.getEndereco());
                            command.Parameters.AddWithValue("@DATA_NSC", cliente.getDataNsc());

                            command.Connection.Open();
                            int result = command.ExecuteNonQuery();

                            command.Connection.Close();

                            // Check Error
                            if (result < 0)
                            {
                                MessageBox.Show("Houve um erro ao Criar o cliente, tente novamente!");
                            }
                            else
                            {
                                    
                                MessageBox.Show("Dados do Cliente " + cliente.getNome()+ " criados com sucesso!");
                                this.Close();
                            }

                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
                
            }
        }

        private void btn_cancelarAlt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
