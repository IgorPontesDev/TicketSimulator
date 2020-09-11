using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Tickets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dGVItems.AllowUserToAddRows = true;
            dGVResultado.AllowUserToAddRows = false;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRodar_Click(object sender, EventArgs e)
        {
            if (txtValorTicket.Text == "")
            {
                MessageBox.Show("Insira o preço do ticket!");
                return;
            }
            if (txtQtd.Text == "")
            {
                MessageBox.Show("Insira a quantidade de tickets!");
                return;
            }
            if (dGVItems.Rows[0].Cells[1].Value == null)
            {
                MessageBox.Show("Selecione uma lista de tickets!");
                return;
            }
            dGVResultado.ClearSelection();
            dGVResultado.Rows.Clear();
            Double totalGasto = 0;
            List<string> listaDeItem = new List<string>();
            List<Double> listaDePorcentagem = new List<double>();
            List<Double> listaDeValores = new List<double>();
            List<int> listaDeQtd = new List<int>();
            int quantidadeDeTicket = int.Parse(txtQtd.Text);
            Double somaPorcentagem = 0;
            List<string> itemSorteado = new List<string>();
            Double numSorteado = 0;
            Random random = new Random();
            Double somaTotalGanho = 0;
            totalGasto = Double.Parse(txtQtd.Text.ToString()) * Double.Parse(txtValorTicket.Text.ToString());
            #region preenche as listas
            foreach (DataGridViewRow item in dGVItems.Rows)
            {
                if (item.Cells[1].Value != null)
                    listaDeItem.Add(item.Cells[1].Value.ToString());
            }
            foreach (DataGridViewRow item in dGVItems.Rows)
            {
                if (item.Cells[3].Value != null)
                    listaDeValores.Add(Double.Parse(item.Cells[3].Value.ToString()));
            }
            foreach (DataGridViewRow item in dGVItems.Rows)
            {
                if (item.Cells[2].Value != null)
                {
                    listaDePorcentagem.Add(Double.Parse(item.Cells[2].Value.ToString()));
                    somaPorcentagem += Double.Parse(item.Cells[2].Value.ToString());
                }
            }
            foreach (DataGridViewRow item in dGVItems.Rows)
            {
                if (item.Cells[0].Value != null)
                    listaDeQtd.Add(int.Parse(item.Cells[0].Value.ToString()));
            }
            if (somaPorcentagem != 100)
            {
                MessageBox.Show("A soma das porcentagens não é igual a 100% por favor verifique");
                return;
            }

            #endregion
            #region preenche resultado
            for (int i = 0; i < quantidadeDeTicket; i++)
            {
                numSorteado = GetRandomDoubleNumber(0, somaPorcentagem, random);
                string itemAtualSorteado = RetornaItemSorteado(numSorteado, listaDePorcentagem, somaPorcentagem, listaDeItem).ToString();
                itemSorteado.Add(itemAtualSorteado);
                int indexItemSorteado = listaDeItem.IndexOf(itemAtualSorteado);
                if (dGVResultado.Rows.Count == 0)
                {
                    dGVResultado.Rows.Add(listaDeQtd[indexItemSorteado], listaDeItem[indexItemSorteado], listaDeValores[indexItemSorteado] * listaDeQtd[indexItemSorteado]);
                }
                else
                {
                    for (int j = 0; j < dGVResultado.Rows.Count; j++)
                    {
                        string itemDaLinhaAtual = dGVResultado.Rows[j].Cells[1].Value.ToString();
                        if (itemAtualSorteado == itemDaLinhaAtual)
                        {
                            int qtdItemLinhaAtual = int.Parse(dGVResultado.Rows[j].Cells[0].Value.ToString()); //pega a qtd atual de itens tirados
                            Double valorItemLinhaAtual = Double.Parse(dGVResultado.Rows[j].Cells[2].Value.ToString()); //pega o valor atual dos itens
                            dGVResultado.Rows[j].Cells[0].Value = qtdItemLinhaAtual + listaDeQtd[indexItemSorteado];
                            dGVResultado.Rows[j].Cells[2].Value = valorItemLinhaAtual + (listaDeQtd[indexItemSorteado] * listaDeValores[indexItemSorteado]);
                            break;
                        }
                        if (j == dGVResultado.Rows.Count - 1)//se ta no fim da linha e n achou, adiciona o item
                            dGVResultado.Rows.Add(listaDeQtd[indexItemSorteado], listaDeItem[indexItemSorteado], listaDeValores[indexItemSorteado] * listaDeQtd[indexItemSorteado]);
                    }
                }

            }
            foreach (DataGridViewRow item in dGVResultado.Rows)
            {
                double valorItemAtual = Double.Parse(item.Cells[2].Value.ToString());
                somaTotalGanho += valorItemAtual;
            }
            txtTotalGanhoItens.Text = somaTotalGanho.ToString();
            txtTotalGasto.Text = totalGasto.ToString();
            double lucroFinal = somaTotalGanho - totalGasto;
            txtLucro.Text = lucroFinal.ToString();
            #endregion
        }
        public string RetornaItemSorteado(double numSorteado, List<Double> listaDePorcentagem, Double somaPorcentagem, List<string> listaDeItem)
        {
            string item = "";
            double porcentagemAtual = 0;
            double porcentagemParaOPremio = 0;
            for (int i = 0; i < listaDePorcentagem.Count; i++)
            {
                if (i == 0)
                {
                    if (numSorteado <= listaDePorcentagem[i])
                    {
                        item = listaDeItem[i];
                        break;
                    }
                    else
                    {
                        porcentagemAtual += listaDePorcentagem[i];
                    }

                }
                else if (i > 0)
                {
                    porcentagemParaOPremio = porcentagemAtual + listaDePorcentagem[i];
                    if (numSorteado > porcentagemAtual && numSorteado <= porcentagemParaOPremio)
                    {
                        item = listaDeItem[i];
                        break;
                    }
                    else
                    {
                        porcentagemAtual += listaDePorcentagem[i];
                    }
                }
            }
            return item;
        }
        public double GetRandomDoubleNumber(double v1, double v2, Random random)
        {

            Double numSorteado = random.NextDouble() * (v2 - v1) + v1;
            return numSorteado;
        }
        private void lBPorcentagem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnZerar_Click(object sender, EventArgs e)
        {
            dGVItems.Rows.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemSelecionado = cbListaTicketsPromo.SelectedItem.ToString();
            if (itemSelecionado.Equals("Ticket Promoção 09/20"))
            {
                dGVItems.Rows.Add("1", "Lâmina Sagrada[1]", "0,3", "350");
                dGVItems.Rows.Add("1", "Sapatos do Perseguidor", "0,3", "60");
                dGVItems.Rows.Add("1", "Botas Imperiais", "0,3", "650");
                dGVItems.Rows.Add("1", "Luvas Imperiais[1]", "0,5", "47");
                dGVItems.Rows.Add("1", "Escudo de Nero[1]", "0,5", "40");
                dGVItems.Rows.Add("1", "Chicle de bola", "5", "3");
                dGVItems.Rows.Add("3", "Doce Mágico", "5,5", "0,060");
                dGVItems.Rows.Add("5", "Bolinho Divino", "6", "0,300");
                dGVItems.Rows.Add("7", "Grande Pílula de Combate", "6,6", "0,200");
                dGVItems.Rows.Add("10", "Poção Média de Vida", "7", "0,120");
                dGVItems.Rows.Add("8", "Poção de Guyak", "7", "0,12");
                dGVItems.Rows.Add("5", "Suco de Gato", "8", "0,075");
                dGVItems.Rows.Add("12", "Pergaminho de Aspersion", "9", "0");
                dGVItems.Rows.Add("6", "Acarajé", "10", "0,09");
                dGVItems.Rows.Add("5", "Cartão Kafra", "11", "0,05");
                dGVItems.Rows.Add("6", "Perg. de Precisão Apurada", "11", "0,08");
                dGVItems.Rows.Add("10", "Elixir Rubro", "12", "0,06");
                MessageBox.Show("Clique em cima do campo desejado para editar o valor!");
            }
        }
    }
}
