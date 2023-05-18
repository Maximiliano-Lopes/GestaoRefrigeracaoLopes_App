using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeracaoLopes_App
{

    public partial class PagamentoForm : Form
    {
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

            datePickAreaEntrada.Value = DateTime.Now;

            id_place.Text = Principal.id.ToString();
            inputCPF.Text = Principal.cpf;
            inputNome.Text = Principal.nome;
            inputNomeProduto.Text = NovoServico.nomeProduto;

            numericUpDownPreco.Value = Decimal.Parse(NovoServico.precoTotal.ToString());



        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_confirmarInfo_Click(object sender, EventArgs e)
        {

            estado_pagamento = int.Parse(listEstadoPagamento.SelectedIndex.ToString())+2;
            meio_pagamento = int.Parse(listMeioPagamento.SelectedIndex.ToString())+2;
            dataPagamento = DateTime.Parse(datePickAreaEntrada.Text);
            precoFinal = numericUpDownPreco.Value;
            descricaoPagamento = inputDescricaoProduto.Text.ToString();

            this.Close();

        }
    }
}
