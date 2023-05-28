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
    public partial class DetalhesServico : Form
    {
         int estadoValue;
        public DetalhesServico()
        {
            InitializeComponent();
        }
        
        private void DetalhesServico_Load(object sender, EventArgs e)
        {
            datePickAreaEntrada.Enabled = false;
            dateTimePickerTermino.Enabled = false;
            listEstadoPagamento.Enabled = false;
            listEstadoServico.Enabled = false;
            numericUpDownOrcamento.Enabled = false;
            numericUpDownPreco.Enabled = false;
            textBoxNomeProduto.Enabled = false;
            textBoxDescricaoProduto.Enabled = false;


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
                                    //        7                     8                   9              10               11              12
                                    //Servicos.ESTADO, Servicos.NUMERO_ORÇAMENTO, Servicos.INFO, Servicos.PRECO, Pagamento.ESTADO, Pagamento.PRODUTO



                                    idCliente_Place.Text = reader.GetInt32(0).ToString();
                                    inputNome.Text = reader.GetString(1);
                                    inputEmail.Text = reader.GetString(2);
                                    inputEnd.Text = reader.GetString(3);
                                    inputTelefone.Text = reader.GetString(4);
                                    datePickAreaEntrada.Value = reader.GetDateTime(5);
                                    dateTimePickerTermino.Value = reader.GetDateTime(6);
                                    listEstadoServico.SelectedIndex = reader.GetInt32(7) == 1 ? 1 : 0;
                                    numericUpDownOrcamento.Value = reader.GetInt32(8) == 0 ? 1 : reader.GetInt32(8);//******
                                    textBoxDescricaoProduto.Text = reader.GetString(9);
                                    numericUpDownPreco.Value = reader.GetDecimal(10);
                                    listEstadoPagamento.SelectedIndex = reader.GetInt32(11) == 1 ? 1 : 0;
                                    textBoxNomeProduto.Text = reader.GetString(12);

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

        private void btn_editarInfo_Click(object sender, EventArgs e)
        {
            dateTimePickerTermino.Enabled = true;
            listEstadoPagamento.Enabled = false;
            listEstadoServico.Enabled = true;
            numericUpDownOrcamento.Enabled = true;
            numericUpDownPreco.Enabled = true;
            textBoxNomeProduto.Enabled = true;
            textBoxDescricaoProduto.Enabled = true;
            btn_editarInfoPaga.Enabled = false;

            btn_confirmarAlt.Visible = true;
            btn_cancelarAlt.Visible = true;
            
        }

        private void btn_confirmarAlt_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Gostaria de atualizar as informações do pagamento também?",
                      "Informação", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    MessageBox.Show("YES");
                    //Enviar para um form com as informações do pagamento após atualizar as informações do serviço.
                    atualizarInformacoes(true);
                    break;
                case DialogResult.No:

                    //Continuar a atualização as informações do serviço
                    atualizarInformacoes(false);
                    break;
            }



        }

        private void atualizarInformacoes(bool resposta)
        {
            String resultado = "";
            String connectionString = ConfigurationManager.ConnectionStrings["RefrigeracaoLopes_App.Properties.Settings.refrigeracaoDB"].ConnectionString;

            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";


            if (DateTime.Compare(DateTime.Parse(dateTimePickerTermino.Text), DateTime.Parse(datePickAreaEntrada.Text)) == -1)
            {
                resultado = "A data de termino não pode ser anterior a data de entrada!";
            }
            else
            {
                if (numericUpDownOrcamento.Value.ToString().Length == 0 || numericUpDownPreco.Value.ToString().Length == 0 || textBoxNomeProduto.Text.ToString().Length == 0 || textBoxDescricaoProduto.Text.ToString().Length == 0)
                {
                    resultado = "Verifique os dados que inseriu, nenhum deles pode ser vazio.";

                }
                else
                {
                    try 
                    {
                        string cmdString = "UPDATE Serviços SET [PRECO] = @PRECO, [ESTADO] = @ESTADO, [INFO] = @INFO, [DATA_TERMINO] = @DATA_TERMINO, [NUMERO_ORÇAMENTO] = @NUMERO_ORÇAMENTO WHERE ID = @ServicoID";

                        using (SqlConnection connectionUpdate = new SqlConnection(connectionString))


                        using (SqlCommand commandUpdate = new SqlCommand(cmdString, connectionUpdate))
                        {
                            Decimal precoValue = numericUpDownPreco.Value;
                            
                            String infoValue = textBoxDescricaoProduto.Text;
                            DateTime dataTerminoValue = dateTimePickerTermino.Value;
                            int numeroOrcamentoValue = int.Parse(numericUpDownOrcamento.Value.ToString());

                            Console.WriteLine(listEstadoServico.SelectedItem.ToString() + listEstadoServico.SelectedIndex);

                            commandUpdate.Parameters.AddWithValue("@PRECO", precoValue.ToString(nfi));
                            commandUpdate.Parameters.AddWithValue("@ESTADO", estadoValue);
                            commandUpdate.Parameters.AddWithValue("@INFO", infoValue);
                            commandUpdate.Parameters.AddWithValue("@DATA_TERMINO", dataTerminoValue);
                            commandUpdate.Parameters.AddWithValue("@NUMERO_ORÇAMENTO", numeroOrcamentoValue);
                            commandUpdate.Parameters.AddWithValue("@ServicoID", int.Parse(idServico_Place.Text.ToString()));

                            
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
                        


                    }
                    catch (Exception ex) {
                    Console.WriteLine(ex.ToString());
                }
               }    
            } 
            MessageBox.Show(resultado); 

            //IF PARA VER SE O QUER ATUALZIAR O PAG
            if (resposta)
            {
                //abrir pagamento para atualizar os dados
                MessageBox.Show("ABRIRÁ O PAGAMENTO AQUI");
            }
             
        }
        
        private void TrocouDeItem(object sender, EventArgs e)
        {
            if (listEstadoServico.SelectedIndex != -1)
            {
                // Atualize a variável com o valor do item selecionado
                estadoValue = listEstadoServico.SelectedIndex == 0 ? 2 : 1;
                Console.WriteLine(estadoValue);
            }
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

        private void btn_editarInfoPaga_Click(object sender, EventArgs e)
        {
            PagamentoForm pagamentoForm = new PagamentoForm();

            pagamentoForm.btn_confirmarInfo.Visible = false;
            pagamentoForm.id_place.Visible = true;
            pagamentoForm.label9.Visible = true;
            pagamentoForm.idServico = int.Parse(idServico_Place.Text.ToString());
            pagamentoForm.idPagamento = int.Parse(idPagamento_Place.Text.ToString());
            pagamentoForm.btn_confirmarAlteracoesPag.Visible = true;
            pagamentoForm.nomeCliente = inputNome.Text;
            pagamentoForm.Show();
        }
    }
}
