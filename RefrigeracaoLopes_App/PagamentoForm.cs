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


        public PagamentoForm()
        {
            InitializeComponent();


        }
        private void PagamentoForm_Load(object sender, EventArgs e)
        {
            
            String nomeCliente = "";


            datePickAreaEntrada.Value = DateTime.Now;

            id_place.Text = Principal.id.ToString();
            inputCPF.Text = Principal.cpf;
            inputNome.Text = Principal.nome;
            inputNomeProduto.Text = NovoServico.nomeProduto;

            numericUpDownPreco.Value = Decimal.Parse(NovoServico.precoTotal.ToString());

            if (Principal.cpf.Length != 0)
            {

                String connectionString = ConfigurationManager.ConnectionStrings["RefrigeracaoLopes_App.Properties.Settings.refrigeracaoDB"].ConnectionString;

                try
                {
                    string queryString = "SELECT * FROM Pagamento";
                    queryString += "WHERE ID = "+ idPagamento + " AND ID_SERVICO = " + int.Parse(id_place.Text.ToString());



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

                                    id_place.Text = reader.GetInt32(0).ToString();
                                    inputNome.Text = nomeCliente;
                                    inputNomeProduto.Text = reader.GetString(1);
                                    numericUpDownPreco.Value = reader.GetDecimal(2);
                                    inputCPF.Text = reader.GetString(5);

                                    Console.WriteLine(command.CommandText);
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
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_confirmarInfo_Click(object sender, EventArgs e)
        {
            
            descricaoPagamento = inputDescricaoProduto.Text.ToString();
            meio_pagamento = int.Parse(listMeioPagamento.SelectedIndex.ToString())+1;
            dataPagamento = DateTime.Parse(datePickAreaEntrada.Text);
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



        }
    }
}
