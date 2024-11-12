using System.Diagnostics;
using System.Linq.Expressions;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }

        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "9";
        }

        private void btn_limpa_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = "";
            lblOperacao.Text = "";

        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txt_resultado.Text);
            txt_resultado.Text = "";
            lblOperacao.Text = "/";

        }

        private void btn_vezes_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txt_resultado.Text);
            txt_resultado.Text = "";
            lblOperacao.Text = "*";

        }

        private void btn_menos_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txt_resultado.Text);
            txt_resultado.Text = "";
            lblOperacao.Text = "-";

        }

        private void btn_mais_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txt_resultado.Text);
            txt_resultado.Text = "";
            lblOperacao.Text = "+";
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txt_resultado.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txt_resultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txt_resultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txt_resultado.Text);
                    break;
            }
            txt_resultado.Text = Convert.ToString(Resultado);
            lblOperacao.Text = "=";

        }

        private void btn_virgula_Click(object sender, EventArgs e)
        {
            if (!txt_resultado.Text.Contains(","))
            txt_resultado.Text += ",";
        }
    }
}
