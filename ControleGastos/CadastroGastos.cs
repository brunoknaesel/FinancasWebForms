using ControleGastos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleGastos
{
    public partial class CadastroGastos : Form
    {
        public CadastroGastos()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDescricao.Text) && nmrValor.Value != 0 && dateCompra.Value != null)
            {
                Gasto novoGasto = new Gasto
                {
                    Descricao = txtDescricao.Text,
                    Categoria = txtCategoria.Text,
                    Valor = nmrValor.Value,
                    FoiNecessaria = checkNecessaria.Checked,
                    DataCompra = dateCompra.Value
                };
            }
            else
            {
                //Adiciona * nos obrigatorios - Opção 1

                /*lblCategoria.Text = "* " + lblCategoria.Text;
                lblData.Text = "* " + lblData.Text;
                lblNecessaria.Text = "* " + lblNecessaria.Text;
                lblValor.Text = "* " + lblValor.Text;*/

                lblDescricao.ForeColor = Color.Red;
                lblData.ForeColor = Color.Red;
                lblNecessaria.ForeColor = Color.Red;
                lblValor.ForeColor = Color.Red;

                MessageBox.Show("Preencha todos os campos obrigatórios");
            }



        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CadastroGastos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controle_gastoDataSet.gasto'. Você pode movê-la ou removê-la conforme necessário.
            this.gastoTableAdapter.Fill(this.controle_gastoDataSet.gasto);

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
