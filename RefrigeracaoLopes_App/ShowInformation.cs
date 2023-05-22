using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Data.SqlClient;



namespace RefrigeracaoLopes_App
{
    public partial class SelecInformation : Form
    {
        public static String variavelSelect = "";

        DateTime dataInicial;
        DateTime dataFinal;


        public SelecInformation()
        {
            InitializeComponent();

        }

        private void ShowInformation_Load(object sender, EventArgs e)
        {
            if (variavelSelect == "RequisicaoRelatorios")
            {

                
                ReqRelatorio();
                //CHAMAR O METODO DO RELATÓRIO COM PDF E ETC


            }

        }
        public void ReqPagamentosPendentes()
        {

            //Requisitar os pagamentos pendentes
            //Enviar os dados para a dataGridView

            MecanismoDeBusca mecanismoDeBusca = new MecanismoDeBusca();

            String connectionString = ConfigurationManager.ConnectionStrings["RefrigeracaoLopes_App.Properties.Settings.refrigeracaoDB"].ConnectionString;
            string queryPagPend = "SELECT  ID, PRODUTO, FORMAT(Pagamento.PRECO, 'N2') as PRECO , Moda_Pagamento, Meio_Pagamento, CPF_CNPJ,ESTADO, DATA,ID_SERVICO,DESCRICAO FROM Pagamento WHERE ESTADO = 2 ORDER BY ID";
            DataTable novaTabela = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryPagPend, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    novaTabela.Load(reader);

                }

                connection.Close();
            }

            ResultadoPesquisa resultadoPesquisa = new ResultadoPesquisa(novaTabela);
            resultadoPesquisa.Show();
            


        }
        public void ReqPagamentosPagos()
        {

            //Requisitar os pagamentos pendentes
            //Enviar os dados para a dataGridView

            MecanismoDeBusca mecanismoDeBusca = new MecanismoDeBusca();

            String connectionString = ConfigurationManager.ConnectionStrings["RefrigeracaoLopes_App.Properties.Settings.refrigeracaoDB"].ConnectionString;
            string queryPagPend = "SELECT ID, PRODUTO, FORMAT(Pagamento.PRECO, 'N2') as PRECO , Moda_Pagamento, Meio_Pagamento, CPF_CNPJ,ESTADO, DATA,ID_SERVICO,DESCRICAO FROM Pagamento WHERE ESTADO = 1 ORDER BY ID";
            DataTable novaTabela = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryPagPend, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    novaTabela.Load(reader);

                }

                connection.Close();
            }

            ResultadoPesquisa resultadoPesquisa = new ResultadoPesquisa(novaTabela);
            resultadoPesquisa.Show();

        }
        public void ReqServicosPendentes()
        {

            //Requisitar os pagamentos pendentes
            //Enviar os dados para a dataGridView

            MecanismoDeBusca mecanismoDeBusca = new MecanismoDeBusca();

            String connectionString = ConfigurationManager.ConnectionStrings["RefrigeracaoLopes_App.Properties.Settings.refrigeracaoDB"].ConnectionString;
            string queryPagPend = "SELECT ID, CPF_CNPJ,DATA_ENTRADA,FORMAT(PRECO, 'N2') as PRECO ,PAGAMENTO_ID,ESTADO,INFO,DATA_TERMINO,NUMERO_ORÇAMENTO FROM Serviços WHERE ESTADO = 2 ORDER BY ID";
            DataTable novaTabela = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryPagPend, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    novaTabela.Load(reader);

                }

                connection.Close();
            }

            ResultadoPesquisa resultadoPesquisa = new ResultadoPesquisa(novaTabela);
            resultadoPesquisa.Show();

        }
        public void ReqServicosConcluidos()
        {

            //Requisitar os pagamentos pendentes
            //Enviar os dados para a dataGridView

            MecanismoDeBusca mecanismoDeBusca = new MecanismoDeBusca();

            String connectionString = ConfigurationManager.ConnectionStrings["RefrigeracaoLopes_App.Properties.Settings.refrigeracaoDB"].ConnectionString;
            string queryPagPend = "SELECT ID, CPF_CNPJ,DATA_ENTRADA,FORMAT(PRECO, 'N2') as PRECO, PAGAMENTO_ID,ESTADO,INFO,DATA_TERMINO,NUMERO_ORÇAMENTO FROM Serviços WHERE ESTADO = 1 ORDER BY ID";
            DataTable novaTabela = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryPagPend, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    novaTabela.Load(reader);

                }

                connection.Close();
            }

            ResultadoPesquisa resultadoPesquisa = new ResultadoPesquisa(novaTabela);
            resultadoPesquisa.Show();

        }

        
        public void ReqRelatorio()
        {
            this.Text = "Requisitar Relatório";

            label3.Visible = true;
            checkedListBox1.Visible = true;

            dateTimeInicio.Value = DateTime.Now;
            dateTimeFinal.Value = DateTime.Now;
            btn_confirmarAlt.Visible = true;
            
        }
        private void MontarPDF()
        {
            PdfDocument pdf = new PdfDocument();
            XFont font = new XFont("Arial", 8);
            String dataHoje = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();
            String caminhoArquivoPDF = "Relatorio_" + dataHoje + ".pdf";
            String connectionString = ConfigurationManager.ConnectionStrings["RefrigeracaoLopes_App.Properties.Settings.refrigeracaoDB"].ConnectionString;

            if (checkedListBox1.CheckedIndices.Count > 0)
            {
                foreach (int indiceSelecionado in checkedListBox1.CheckedIndices)
                {
                    PdfPage page = pdf.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(page);

                    Console.WriteLine(checkedListBox1.Items[indiceSelecionado].ToString() + " : " + indiceSelecionado);

                    if (indiceSelecionado == 0)
                    {
                        int row = 0;
                        double x = 10;
                        double y = 40;

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            string queryNovosClientes = "SELECT ID,CPF_CNPJ,NOME,TELEFONE,ENDEREÇO,DATA_NSC FROM CLIENTES WHERE DATA_CRIACAO BETWEEN @DataInicio AND @DataFim  ORDER BY ID";

                            connection.Open();
                            SqlCommand command = new SqlCommand(queryNovosClientes, connection);

                            command.Parameters.AddWithValue("@DataInicio", dateTimeInicio.Value);
                            command.Parameters.AddWithValue("@DataFim", dateTimeFinal.Value);

                            SqlDataReader reader = command.ExecuteReader();

                            gfx.DrawString("Novos Clientes registrados entre " + dateTimeInicio.Value.ToShortDateString() + " e " + dateTimeFinal.Value.ToShortDateString(), font, XBrushes.Black, 10, 25);

                            int colunaIDClienteX = 30;

                            gfx.DrawString("ID  | NOME |   CPF_CNPJ   |  TELEFONE  |  ENDEREÇO  |  DATA_NSC", font, XBrushes.Black, x + 40, y + 5);

                            while (reader.Read())
                            {
                                string colunaIDClienteValor = reader["ID"].ToString();
                                string colunaNOMEClienteValor = reader["NOME"].ToString();
                                string colunaCPF_CNPJValor = reader["CPF_CNPJ"].ToString();
                                string colunaTELEFONEValor = reader["TELEFONE"].ToString();
                                string colunaENDERECOValor = reader["ENDEREÇO"].ToString();
                                string colunaDATA_NSCValor = reader["DATA_NSC"].ToString();

                                // Define a posição na página para escrever os valores
                                x = 20;
                                y += 20;

                                // Escreve os valores no PDF
                                gfx.DrawString(colunaIDClienteValor + "  |  " + colunaNOMEClienteValor + "  |  " + colunaCPF_CNPJValor + "  |  " + colunaTELEFONEValor + "  |  " + colunaENDERECOValor + "  |  " + colunaDATA_NSCValor, font, XBrushes.Black, x + colunaIDClienteX, y);

                                row++;
                            }

                            gfx.DrawString("Total de Novos Clientes registrados: " + row, font, XBrushes.Black, x, y + 30);

                            reader.Close();
                            connection.Close();
                        }
                    }
                    else if (indiceSelecionado == 1)
                    {
                        int row = 0;
                        double x = 10;
                        double y = 40;

                        string queryNovosServiços = "SELECT Serviços.ID, Serviços.CPF_CNPJ, Clientes.NOME, DATA_ENTRADA, FORMAT(PRECO, 'N2') as PRECO, PAGAMENTO_ID, ESTADO, INFO, DATA_TERMINO, NUMERO_ORÇAMENTO FROM Serviços, Clientes WHERE DATA_ENTRADA BETWEEN @DataInicio AND @DataFim AND Clientes.CPF_CNPJ = Serviços.CPF_CNPJ";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand(queryNovosServiços, connection);

                            command.Parameters.AddWithValue("@DataInicio", dateTimeInicio.Value);
                            command.Parameters.AddWithValue("@DataFim", dateTimeFinal.Value);

                            SqlDataReader reader = command.ExecuteReader();

                            gfx.DrawString("Novos Serviços registrados entre " + dateTimeInicio.Value.ToShortDateString() + " e " + dateTimeFinal.Value.ToShortDateString(), font, XBrushes.Black, x + 10, 25);

                            int colunaIDClienteX = 30;

                            gfx.DrawString("SERVIÇO-ID  | NOME |   CPF_CNPJ   |  ENTRADA  |  PREÇO  |  PAGAMENTO_ID | ESTADO | INFO | DATA_TERMINO | NUMERO_ORÇAMENTO", font, XBrushes.Black, x + 40, y + 5);
                            Decimal totalPagamentos = 0;
                            while (reader.Read())
                            {
                                string colunaIDServicoValor = reader["ID"].ToString();
                                string colunaCPF_CNPJValor = reader["CPF_CNPJ"].ToString();
                                string colunaNOMEClienteValor = reader["NOME"].ToString();
                                string colunaENTRADAValor = reader["DATA_ENTRADA"].ToString();
                                string colunaPRECOValor = reader["PRECO"].ToString();
                                string colunaPAGAMENTO_IDValor = reader["PAGAMENTO_ID"].ToString();
                                string colunaESTADOValor = reader["ESTADO"].ToString();
                                string colunaINFOValor = reader["INFO"].ToString();
                                string colunaDATA_TERMINOValor = reader["DATA_TERMINO"].ToString();
                                string colunaNUMERO_ORCAMENTOValor = reader["NUMERO_ORÇAMENTO"].ToString();

                                
                                x = 20;
                                y += 20;
                                totalPagamentos += Decimal.Parse(reader["PRECO"].ToString());
                                // Escreve os valores no PDF
                                gfx.DrawString(colunaIDServicoValor + "  |  " + colunaNOMEClienteValor + "  |  " + colunaCPF_CNPJValor + "  |  " + colunaENTRADAValor + "  |  " + colunaPRECOValor + "  |  " + colunaPAGAMENTO_IDValor + "  |  " + colunaESTADOValor + "  |  " + colunaINFOValor + "  |  " + colunaDATA_TERMINOValor + "  |  " + colunaNUMERO_ORCAMENTOValor, font, XBrushes.Black, x + colunaIDClienteX, y);

                                row++;
                            }

                            gfx.DrawString("Total de Novos Serviços registrados: " + row + " | TOTAL dos Preços Orçados R$" + totalPagamentos, font, XBrushes.Black, x, y + 30);

                            reader.Close();
                            connection.Close();
                        }
                    }
                    else if (indiceSelecionado == 2)
                    {
                        int row = 0;
                        double x = 10;
                        double y = 40;

                        string queryNovosPagamentos = "SELECT Pagamento.ID, Pagamento.CPF_CNPJ, Clientes.NOME, Pagamento.DATA,FORMAT(Pagamento.PRECO, 'N2') as PRECO, PRODUTO, Pagamento.ESTADO,  ID_SERVICO , DESCRICAO ";
                        queryNovosPagamentos += "FROM Pagamento, Clientes, Serviços ";
                        queryNovosPagamentos += " WHERE DATA_ENTRADA BETWEEN @DataInicio AND @DataFim AND Clientes.CPF_CNPJ = Pagamento.CPF_CNPJ  AND Serviços.ID = Pagamento.ID_SERVICO;";


                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand(queryNovosPagamentos, connection);

                            command.Parameters.AddWithValue("@DataInicio", dateTimeInicio.Value);
                            command.Parameters.AddWithValue("@DataFim", dateTimeFinal.Value);

                            SqlDataReader reader = command.ExecuteReader();

                            gfx.DrawString("Novos Pagamentos registrados entre " + dateTimeInicio.Value.ToShortDateString() + " e " + dateTimeFinal.Value.ToShortDateString(), font, XBrushes.Black, x + 10, 25);

                            int colunaIDClienteX = 30;

                            gfx.DrawString("PAGAMENTO-ID  | NOME |   CPF_CNPJ   |  ENTRADA  |  PREÇO  |  PRODUTO | ESTADO | SERVIÇO-ID | DESCRIÇÃO ", font, XBrushes.Black, x + 40, y + 5);
                            Decimal totalPagamentos = 0;
                            while (reader.Read())
                            {
                                string colunaIDServicoValor = reader["ID"].ToString();
                                string colunaCPF_CNPJValor = reader["CPF_CNPJ"].ToString();
                                string colunaNOMEClienteValor = reader["NOME"].ToString();
                                string colunaENTRADAValor = reader["DATA"].ToString();
                                string colunaPRECOValor = reader["PRECO"].ToString();
                                string colunaPAGAMENTO_IDValor = reader["PRODUTO"].ToString();
                                string colunaESTADOValor = reader["ESTADO"].ToString();
                                string colunaINFOValor = reader["ID_SERVICO"].ToString();
                                string colunaDATA_TERMINOValor = reader["DESCRICAO"].ToString();

                                totalPagamentos += Decimal.Parse(reader["PRECO"].ToString());

                                // Define a posição na página para escrever os valores
                                x = 20;
                                y += 20;

                                
                                gfx.DrawString(colunaIDServicoValor + "  |  " + colunaNOMEClienteValor + "  |  " + colunaCPF_CNPJValor + "  |  " + colunaENTRADAValor + "  |  " + colunaPRECOValor + "  |  " + colunaPAGAMENTO_IDValor + "  |  " + colunaESTADOValor + "  |  " + colunaINFOValor + "  |  " + colunaDATA_TERMINOValor, font, XBrushes.Black, x + colunaIDClienteX, y);

                                row++;
                            }

                            gfx.DrawString("Total de Novos Pagamentos registrados: " + row +" | TOTAL dos Pagamentos R$"+ totalPagamentos, font, XBrushes.Black, x, y + 30);

                            reader.Close();
                            connection.Close();
                        }
                    }
                }
                pdf.Save(caminhoArquivoPDF);
                pdf.Close();
                Process.Start(caminhoArquivoPDF);
            }
        }

            private void btn_confirmarAlt_Click(object sender, EventArgs e)
        {
            if (variavelSelect == "RequisicaoRelatorios")
            {
                if (DateTime.Compare(DateTime.Parse(dateTimeFinal.Text), DateTime.Parse(dateTimeInicio.Text)) == -1)
                {
                    MessageBox.Show("A data final não pode ser anterior a data do inicio!");
                }
                else
                {
                    if(checkedListBox1.CheckedItems.Count > 0)
                    {

                        MontarPDF();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Você precisa selecionar pelo menos um item da lista de requisitos para o relatório!");
                    }
                    
                }
            }
        }
    }
}
