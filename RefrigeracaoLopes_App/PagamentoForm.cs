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

            descricaoPagamento = inputDescricaoProduto.Text.ToString();
            meio_pagamento = int.Parse(listMeioPagamento.SelectedIndex.ToString())+2;
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
    }
}
