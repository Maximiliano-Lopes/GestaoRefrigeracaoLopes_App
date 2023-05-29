using PdfSharp.Drawing;
using PdfSharp.Pdf.Content.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace RefrigeracaoLopes_App
{

    public partial class PagamentoForm : Form
    {
        public int idPagamento = 0;
        public static String descricaoPagamento;
        public static int meio_pagamento;
        public static int estado_pagamento;
        public static DateTime dataPagamento;
        public static Decimal precoFinal;
        public int idServico = 0;
        public DateTime dataTerminoServico;
        public DateTime dataEntradaServico;

        public String nomeCliente = "";
        public PagamentoForm()
        {
            InitializeComponent();


        }
        private void PagamentoForm_Load(object sender, EventArgs e)
        {


            numericUpDownPreco.Value = Decimal.Parse(NovoServico.precoTotal.ToString());

            if (Principal.cpf.Length != 0)
            {

                String connectionString = ConfigurationManager.ConnectionStrings["RefrigeracaoLopes_App.Properties.Settings.refrigeracaoDB"].ConnectionString;

                try
                {
                    string queryString = "SELECT * FROM Pagamento ";
                    queryString += " WHERE ID = "+ idPagamento + " AND ID_SERVICO = " + idServico;



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

                                    
                                    //[ID],[PRODUTO],[PRECO],[MODA_PAGAMENTO],[MEIO_PAGAMENTO],[CPF_CNPJ],[ESTADO],[DATA],[ID_SERVICO],[DESCRICAO]
                                    datePickAreaPagamento.Value = DateTime.Now;

                                    id_PlaceServico.Text = idServico.ToString();
                                    id_place.Text = idPagamento.ToString();

                                    inputDescricaoProduto.Text = reader.GetString(9);
                                    id_place.Text = reader.GetInt32(0).ToString();
                                    inputNome.Text = nomeCliente;
                                    inputNomeProduto.Text = reader.GetString(1);
                                    numericUpDownPreco.Value = reader.GetDecimal(2);
                                    listMeioPagamento.SelectedIndex = VerificarMeio(reader.GetInt32(4));
                                    inputCPF.Text = reader.GetString(5);
                                    listEstadoPagamento.SelectedIndex = reader.GetInt32(6) == 1 ? 1 : 0; ;
                                    datePickAreaPagamento.Value = reader.GetDateTime(7);


                                }
                                catch (Exception ex)
                                {
                                    connection.Close();
                                    Console.WriteLine(ex.ToString());
                                }
                            }

                            connection.Close();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

        }
        public int VerificarMeio(String meio)
        {
            int index = 0;
            
            switch (meio)
            {
                case "Dinheiro":
                    index = 1;
                    break;
                case "Cartão_de_débito":
                    index = 3;
                    break;
                case "Boleto_bancário":
                    index = 4;
                    break;
                case "Carteira_digital":
                    index = 5;
                    break;
                case "Contactless":
                    index = 6;
                    break;
                case "PIX":
                    index = 7;
                    break;
                case "Cartão_de_crédit":
                    index = 8;
                    break;
                default:
                    index = 1;
                    break;
            }

            return index;
        }
        public int VerificarMeio(int meio)
        {
            int index = 0;

            switch (meio)
            {
                case 1:
                    index = 0;//dinheiro
                    break;
                case 3:
                    index = 1;//Cartão_de_débito
                    break;
                case 4:
                    index = 2;//Boleto_bancário
                    break;
                case 5:
                    index = 3;//Carteira_digital
                    break;
                case 6:
                    index = 4;//Contactless
                    break;
                case 7:
                    index = 5;//PIX
                    break;
                case 8:
                    index = 6;//Cartão_de_crédit
                    break;
                default:
                    index = 1;
                    break;
            }

            return index;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_confirmarInfo_Click(object sender, EventArgs e)
        {
            
            descricaoPagamento = inputDescricaoProduto.Text.ToString();
            meio_pagamento = VerificarMeio(listMeioPagamento.SelectedIndex);
            dataPagamento = DateTime.Parse(datePickAreaPagamento.Text);
            precoFinal = numericUpDownPreco.Value;
            

            this.Close();

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
                e.Graphics.DrawString(listEstadoPagamento.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            }
        }

        private void listMeioPagamento_DrawItem(object sender, DrawItemEventArgs e)
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
                e.Graphics.DrawString(listMeioPagamento.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PEGAR AS INFORMAÇÕES, VERIFICAR E DAR UPDATE
            String connectionString = ConfigurationManager.ConnectionStrings["RefrigeracaoLopes_App.Properties.Settings.refrigeracaoDB"].ConnectionString;
            String resultado;

            if (datePickAreaPagamento.Value.ToString().Length == 0 || numericUpDownPreco.Value.ToString().Length == 0 || inputNomeProduto.Text.ToString().Length == 0 || inputDescricaoProduto.Text.ToString().Length == 0)
            {
                resultado = "Verifique os dados que inseriu, nenhum deles pode ser vazio.";
                MessageBox.Show(resultado);
            }
            else if (DateTime.Compare(datePickAreaPagamento.Value, dataEntradaServico) == -1)
            {
                resultado = "A data do pagamento não pode ser anterior a data de entrada do serviço!";
                MessageBox.Show(resultado);
            }
            else
            {
                try
                {
                    dataPagamento = datePickAreaPagamento.Value;

                    string cmdString = "UPDATE [dbo].[Pagamento] SET [PRODUTO] = @PRODUTO, [PRECO] = @PRECO, [MODA_PAGAMENTO] = @MODA_PAGAMENTO, [MEIO_PAGAMENTO] = @MEIO_PAGAMENTO, [ESTADO] = @ESTADO, [DATA] = @DATA, [DESCRICAO] = @DESCRICAO ";
                    cmdString += " WHERE ID_SERVICO = @ID_SERVICO AND ID = @ID_PAGAMENTO";

                    using (SqlConnection connectionUpdate = new SqlConnection(connectionString))


                    using (SqlCommand commandUpdate = new SqlCommand(cmdString, connectionUpdate))
                    {
                        int estadoValue = listEstadoPagamento.SelectedIndex == 0 ? 2 : 1;



                        commandUpdate.Parameters.AddWithValue("@PRODUTO", inputNomeProduto.Text.ToString());
                        commandUpdate.Parameters.AddWithValue("@PRECO", numericUpDownPreco.Value);
                        commandUpdate.Parameters.AddWithValue("@MODA_PAGAMENTO", 1);
                        commandUpdate.Parameters.AddWithValue("@MEIO_PAGAMENTO", VerificarMeio(listMeioPagamento.SelectedItem.ToString()));
                        commandUpdate.Parameters.AddWithValue("@ESTADO", estadoValue);
                        commandUpdate.Parameters.AddWithValue("@DATA", dataPagamento);
                        commandUpdate.Parameters.AddWithValue("@ID_SERVICO", idServico);
                        commandUpdate.Parameters.AddWithValue("@ID_PAGAMENTO", idPagamento);
                        commandUpdate.Parameters.AddWithValue("@DESCRICAO", inputDescricaoProduto.Text.ToString());


                        string queryString = commandUpdate.CommandText;
                        foreach (SqlParameter p in commandUpdate.Parameters)
                        {
                            queryString = queryString.Replace(p.ParameterName, p.Value.ToString());
                        }
                        Console.WriteLine(queryString);
                        commandUpdate.Connection.Open();


                        int res = commandUpdate.ExecuteNonQuery();
                        commandUpdate.Connection.Close();

                        if (res < 0)
                        {
                            resultado = "Houve um erro ao atualizar os dados, tente novamente!";
                        }
                        else
                        {
                            resultado = "Dados atualizados corretamente!";
                        }
                    }
                    MessageBox.Show(resultado);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            this.Close();
        }
    }
}

