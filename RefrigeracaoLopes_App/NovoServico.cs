using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeracaoLopes_App
{
    public partial class NovoServico : Form
    {
        public static CultureInfo culture = new CultureInfo("pt-BR");

        public static int estadoDoServico;
        public static int estadoDoPagamento = 2; //pendente

        public static DateTime dateEntrada;
        public static DateTime dateTermino;

        public static int numeroOrcamento;

        public static String nomeProduto;
        public static String descricaoProduto;

        public static double precoTotal;

        public NovoServico()
        {
            InitializeComponent();

            

        }

        private void NovoServico_Load(object sender, EventArgs e)
        {
            id_place.Text = Principal.id.ToString();
            inputCPF.Text = Principal.cpf;
            inputNome.Text = Principal.nome;
            inputEmail.Text = Principal.email;
            inputTelefone.Text = Principal.telefone;
            inputEnd.Text = Principal.endereco;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dateTimePickerTermino.Enabled = true;
            }
            else { dateTimePickerTermino.Enabled = false; }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_confirmarAlt_Click(object sender, EventArgs e)
        {
            //verificar as datas:
            if (dateTimePickerTermino.Enabled) { 
                if (DateTime.Compare(DateTime.Parse(dateTimePickerTermino.Text), DateTime.Parse(datePickAreaEntrada.Text)) == -1)
                {
                    MessageBox.Show("A data de termino não pode ser anterior a data da Entrada!");
                }else
                {
                    //Código para dar get em todos os inputs e verificar o restante.

                    if (listEstadoServico.SelectedItem.ToString() == "Concluido")
                    {
                        //termino tem que ser real
                        if (DateTime.Compare(DateTime.Parse(dateTimePickerTermino.Text), DateTime.Parse(datePickAreaEntrada.Text)) == -1 )
                        {
                            MessageBox.Show("A data de termino precisa ser preenchida corretamente!");

                        }
                        else
                        {
                            //Atribuições dos valores

                            estadoDoServico = 1; // Concluido
                            estadoDoPagamento = listEstadoPagamento.SelectedItem.ToString() == "Concluido" ? 1 : 2;

                            dateEntrada = DateTime.Parse(datePickAreaEntrada.Text.ToString());
                            dateTermino = DateTime.Parse(dateTimePickerTermino.Text.ToString());

                            numeroOrcamento = int.Parse(numericUpDownOrcamento.Text) != 0 ? int.Parse(numericUpDownOrcamento.Value.ToString()) : 1 ;
                            precoTotal = double.Parse(numericUpDownPreco.Text) != 0 ? double.Parse(numericUpDownPreco.Value.ToString()) : 1;

                            descricaoProduto = textBoxDescricaoProduto.Text.ToString();

                            nomeProduto = textBoxNomeProduto.Text.ToString();

                            int idServico;
                            int idPagamento;

                            if (estadoDoPagamento == 1)
                            {
                                //No final desse código deverá abrir um Form para inserir todas as informações do Pagamento
                                //POR AQUI SE O ESTADO DO PAGAMENTO FOR CONCLUIDO
                                //Salvar todas as informações na DB

                                //int idServico = Convert.ToInt32(cmd.ExecuteScalar()) e adicionar o  SELECT SCOPE_IDENTITY(); no final do commandString";


                                String connectionString = ConfigurationManager.ConnectionStrings["RefrigeracaoLopes_App.Properties.Settings.refrigeracaoDB"].ConnectionString;

                                string cmdString = "INSERT INTO [dbo].[Serviços] ([CPF_CNPJ],[DATA_ENTRADA],[PRECO],[PAGAMENTO_ID],[ESTADO],[INFO],[DATA_TERMINO],[NUMERO_ORÇAMENTO]) VALUES (@CPF_CNPJ,@DATA_ENTRADA,@PRECO,@PAGAMENTO_ID,@ESTADO,@INFO,@DATA_TERMINO,@NUMERO_ORÇAMENTO); SELECT SCOPE_IDENTITY();";
                                try
                                {
                                    using (SqlConnection connection = new SqlConnection(connectionString))
                                    {

                                        using (SqlCommand command = new SqlCommand(cmdString, connection))
                                        {

                                            


                                            command.Parameters.AddWithValue("@CPF_CNPJ", Principal.cpf);
                                            command.Parameters.AddWithValue("@DATA_ENTRADA", dateEntrada);
                                            command.Parameters.AddWithValue("@PRECO", precoTotal);
                                            command.Parameters.AddWithValue("@PAGAMENTO_ID", DBNull.Value);
                                            command.Parameters.AddWithValue("@ESTADO", estadoDoServico);
                                            command.Parameters.AddWithValue("@INFO", descricaoProduto);
                                            command.Parameters.AddWithValue("@DATA_TERMINO", dateTermino);
                                            command.Parameters.AddWithValue("@NUMERO_ORÇAMENTO", numeroOrcamento);

                                            command.Connection.Open();

                                            idServico = Convert.ToInt32(command.ExecuteScalar());


                                            command.Connection.Close();
                                            
                                        }
                                    }
                                    if (idServico > 0)
                                    {
                                        
                                        
                                        PagamentoForm pagamentoForm = new PagamentoForm();
                                        pagamentoForm.ShowDialog();


                                        string pagamentoString = "INSERT INTO [dbo].[Pagamento] ([PRODUTO],[PRECO],[MODA_PAGAMENTO],[MEIO_PAGAMENTO],[CPF_CNPJ],[ESTADO],[DATA],[ID_SERVICO], [DESCRICAO]) VALUES ";
                                        pagamentoString += "(@PRODUTO, @PRECO, @MODA_PAGAMENTO, @MEIO_PAGAMENTO, @CPF_CNPJ, @ESTADO, @DATA, @ID_SERVICO, @DESCRICAO); SELECT SCOPE_IDENTITY();";


                                        using (SqlConnection connectionNew = new SqlConnection(connectionString))
                                        {

                                            using (SqlCommand commandPag = new SqlCommand(pagamentoString, connectionNew))
                                            {
                                                

                                                commandPag.Parameters.AddWithValue("@PRODUTO", nomeProduto);
                                                commandPag.Parameters.AddWithValue("@PRECO", PagamentoForm.precoFinal);
                                                commandPag.Parameters.AddWithValue("@MODA_PAGAMENTO", 1);
                                                commandPag.Parameters.AddWithValue("@MEIO_PAGAMENTO", PagamentoForm.meio_pagamento);
                                                commandPag.Parameters.AddWithValue("@CPF_CNPJ", Principal.cpf);
                                                commandPag.Parameters.AddWithValue("@ESTADO", PagamentoForm.estado_pagamento);
                                                commandPag.Parameters.AddWithValue("@DATA", PagamentoForm.dataPagamento);
                                                commandPag.Parameters.AddWithValue("@ID_SERVICO", idServico);
                                                commandPag.Parameters.AddWithValue("@DESCRICAO", PagamentoForm.descricaoPagamento);

                                                commandPag.Connection.Open();
                                                
                                                idPagamento = Convert.ToInt32(commandPag.ExecuteScalar());

                                                commandPag.Connection.Close();
                                                MessageBox.Show(idPagamento.ToString());
                                            }
                                        }
                                        if (idPagamento > 0) {
                                            MessageBox.Show("ID PAGAMENTO: " + idPagamento.ToString() + " - ID SERVIÇO: " + idServico.ToString());
                                            cmdString = "UPDATE [dbo].[Serviços] SET [PAGAMENTO_ID] = @PAGAMENTO_ID WHERE ID = @ID_SERVICO;";
                                            
                                                using (SqlConnection connectionUpdate = new SqlConnection(connectionString))
                                                {

                                                    using (SqlCommand commandUpdate = new SqlCommand(cmdString, connectionUpdate))
                                                    {
                                                        
                                                    
                                                        commandUpdate.Parameters.AddWithValue("@PAGAMENTO_ID", idPagamento);
                                                        commandUpdate.Parameters.AddWithValue("@ID_SERVICO", idServico);

                                                        commandUpdate.Connection.Open();

                                                        int res = commandUpdate.ExecuteNonQuery();
                                                        commandUpdate.Connection.Close();
                                                    if (res < 0)
                                                    {
                                                        MessageBox.Show("Houve um erro ao Criar o cliente, tente novamente!");
                                                    }
                                                    else
                                                    {

                                                        MessageBox.Show("Serviço e pagamentos foram registrados corretamente!");
                                                    }
                                                 }
                                             }

                                        }
                                    
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.StackTrace);
                                }
                            }
                            
                        }
                        this.Close();
                    }

                }
            }
            



        }
    }
}
