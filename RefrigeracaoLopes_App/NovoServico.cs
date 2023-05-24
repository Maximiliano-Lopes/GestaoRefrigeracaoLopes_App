using Google.Protobuf.WellKnownTypes;
using PdfSharp.Pdf.Content.Objects;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeracaoLopes_App
{
    public partial class NovoServico : Form
    {
        public static CultureInfo culture = new CultureInfo("pt-BR");

        public static int estadoDoServico;
        public static int estadoDoPagamento; //pendente

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

            datePickAreaEntrada.Value = DateTime.Now;
            dateTimePickerTermino.Value = DateTime.Now;
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
            if (dateTimePickerTermino.Enabled)
            {
                if (DateTime.Compare(DateTime.Parse(dateTimePickerTermino.Text), DateTime.Parse(datePickAreaEntrada.Text)) == -1)
                {
                    MessageBox.Show("A data de termino não pode ser anterior a data da Entrada!");
                }
                else
                {
                    dateTermino = DateTime.Parse(dateTimePickerTermino.Text.ToString());



                    CriarServico();
                }
            }
            else
            {
                //Código para dar get em todos os inputs e verificar o restante.


                dateTermino = DateTime.Parse(datePickAreaEntrada.Text);

                CriarServico();
            }   
            
            



        }
        private void CriarServico()
        {
           
            //Atribuições dos valores

            estadoDoServico = listEstadoServico.SelectedIndex + 2;
            estadoDoPagamento = listEstadoPagamento.SelectedIndex + 2;
            

            dateEntrada = DateTime.Parse(datePickAreaEntrada.Text.ToString());
            

            numeroOrcamento = numericUpDownOrcamento.Text.Length != 0 & int.Parse(numericUpDownOrcamento.Value.ToString()) != 0 ? int.Parse(numericUpDownOrcamento.Value.ToString()) : 1;
            
            precoTotal = double.Parse(numericUpDownPreco.Text) != 0 ? double.Parse(numericUpDownPreco.Value.ToString()) : 1;

            descricaoProduto = textBoxDescricaoProduto.Text.ToString() != "" ? textBoxDescricaoProduto.Text.ToString() : "Sem descrição." ;

            nomeProduto = textBoxNomeProduto.Text.ToString();

            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            
            int idServico;
            int idPagamento;

            Console.WriteLine(estadoDoPagamento);
            if (estadoDoPagamento >= 0)
            {
                String connectionString = ConfigurationManager.ConnectionStrings["RefrigeracaoLopes_App.Properties.Settings.refrigeracaoDB"].ConnectionString;

                string cmdString = "INSERT INTO Serviços ([CPF_CNPJ],[DATA_ENTRADA],[PRECO], [PAGAMENTO_ID],[ESTADO],[INFO],[DATA_TERMINO],[NUMERO_ORÇAMENTO]) VALUES (@CPF_CNPJ,@DATA_ENTRADA,@PRECO,@PAGAMENTO_ID,@ESTADO,@INFO,@DATA_TERMINO, @NUMERO_ORÇAMENTO); SELECT SCOPE_IDENTITY();";
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {

                        using (SqlCommand command = new SqlCommand(cmdString, connection))
                        {

                                command.Parameters.AddWithValue("@CPF_CNPJ", Principal.cpf);
                                command.Parameters.AddWithValue("@DATA_ENTRADA", dateEntrada);
                                command.Parameters.AddWithValue("@PRECO", precoTotal.ToString(nfi));
                                command.Parameters.AddWithValue("@PAGAMENTO_ID", DBNull.Value);
                                command.Parameters.AddWithValue("@ESTADO", estadoDoServico);
                                command.Parameters.AddWithValue("@INFO", descricaoProduto);
                                command.Parameters.AddWithValue("@DATA_TERMINO", dateTermino);
                                command.Parameters.AddWithValue("@NUMERO_ORÇAMENTO", numeroOrcamento);

                                

                                string queryString = command.CommandText;
                                
                            foreach (SqlParameter p in command.Parameters)
                                {
                                queryString = queryString.Replace(p.ParameterName, p.Value.ToString());
                                }
                            Console.WriteLine(queryString);
                            command.Connection.Open();

                            idServico = Convert.ToInt32(command.ExecuteScalar());

                            command.Connection.Close();

                        }
                    }
                    if (idServico > 0)
                    {
                        try {

                            PagamentoForm pagamentoForm = new PagamentoForm();
                            pagamentoForm.listEstadoPagamento.SelectedIndex = estadoDoPagamento == 1 ? 1 : 2;
                            pagamentoForm.listEstadoPagamento.Enabled = false;
                            pagamentoForm.ShowDialog();
                        

                            string pagamentoString = "INSERT INTO [dbo].[Pagamento] ([PRODUTO],[PRECO],[MODA_PAGAMENTO],[MEIO_PAGAMENTO],[CPF_CNPJ],[ESTADO],[DATA],[ID_SERVICO], [DESCRICAO]) VALUES ";
                            pagamentoString += "(@PRODUTO, @PRECO, @MODA_PAGAMENTO, @MEIO_PAGAMENTO, @CPF_CNPJ, @ESTADO, @DATA, @ID_SERVICO, @DESCRICAO); SELECT SCOPE_IDENTITY();";
                            Decimal preco = PagamentoForm.precoFinal > 0 ? PagamentoForm.precoFinal : 1;


                            using (SqlConnection connectionNew = new SqlConnection(connectionString))
                            {

                                using (SqlCommand commandPag = new SqlCommand(pagamentoString, connectionNew))
                                {
                                    String descricaoPagamento = PagamentoForm.descricaoPagamento.Length == 0 ?   "Sem descrição." : PagamentoForm.descricaoPagamento;

                                    commandPag.Parameters.AddWithValue("@PRODUTO", nomeProduto);
                                    commandPag.Parameters.AddWithValue("@PRECO", preco);
                                    commandPag.Parameters.AddWithValue("@MODA_PAGAMENTO", 1);
                                    commandPag.Parameters.AddWithValue("@MEIO_PAGAMENTO", PagamentoForm.meio_pagamento);
                                    commandPag.Parameters.AddWithValue("@CPF_CNPJ", Principal.cpf);
                                    commandPag.Parameters.AddWithValue("@ESTADO", estadoDoPagamento);
                                    commandPag.Parameters.AddWithValue("@DATA", PagamentoForm.dataPagamento);
                                    commandPag.Parameters.AddWithValue("@ID_SERVICO", idServico);
                                    commandPag.Parameters.AddWithValue("@DESCRICAO", descricaoPagamento);

                                    commandPag.Connection.Open();

                                    string sqlCommandText = commandPag.CommandText;
                               
                                    Console.WriteLine(sqlCommandText);

                                    idPagamento = Convert.ToInt32(commandPag.ExecuteScalar());

                                    commandPag.Connection.Close();
                                
                                }
                                if (idPagamento > 0)
                                {

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
                        catch(Exception ex)
                        {
                            Console.WriteLine("Ocorreu um erro ao executar o comando SQL:");
                            Console.WriteLine(ex.ToString());
                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            this.Close();
        }
        
        private void btn_cancelarAlt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listEstadoServico_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            // Verifica se o item está selecionado
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                // Define a cor de fundo quando o item está selecionado
                e.Graphics.FillRectangle(Brushes.LightGreen, e.Bounds);
            }
            else
            {
                // Define a cor de fundo padrão para os itens não selecionados
                e.Graphics.FillRectangle(Brushes.Transparent, e.Bounds);
            }

            // Desenha o texto do item
            if (e.Index >= 0)
            {
                e.Graphics.DrawString(listEstadoServico.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            }
        }

        private void listEstadoPagamento_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            // Verifica se o item está selecionado
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                // Define a cor de fundo quando o item está selecionado
                e.Graphics.FillRectangle(Brushes.LightGreen, e.Bounds);
            }
            else
            {
                // Define a cor de fundo padrão para os itens não selecionados
                e.Graphics.FillRectangle(Brushes.Transparent, e.Bounds);
            }

            // Desenha o texto do item
            if (e.Index >= 0)
            {
                e.Graphics.DrawString(listEstadoServico.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            }
        }
    }
}
