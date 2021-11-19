using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3C1CAIO47.Code.BLL;
using _3C1CAIO47.Code.DTO;
namespace _3C1CAIO47.Ui
{
    public partial class Frm_Produto : Form
    {
        ProdutoBLL bll = new ProdutoBLL();
        HAPPYDTO dto = new HAPPYDTO();
        public Frm_Produto()
        {
            InitializeComponent();
            dgtlista.DataSource = bll.Listar();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            dto.Id = txtid.Text;
            dto.Produto = txtproduto.Text;
            dto.Preco = txtpreco.Text;

            bll.Inserir(dto);
            dgtlista.DataSource = bll.Listar();
            MessageBox.Show("Cadastrado!", "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            dto.Id = txtid.Text;
            bll.Excluir(dto);
            dgtlista.DataSource = bll.Listar();
            MessageBox.Show("Excluido!", "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            dto.Id = txtid.Text;
            dto.Produto = txtproduto.Text;
            dto.Preco = txtpreco.Text;


            bll.Editar(dto);


            MessageBox.Show("Alterado com sucesso!", "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgtlista.DataSource = bll.Listar();
        }

        private void listar(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgtlista.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtproduto.Text = dgtlista.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtpreco.Text = dgtlista.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
