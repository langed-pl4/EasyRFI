using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyRFI
{
    public partial class frmPergunta : Form
    {
        string jsonprod = "";
        string jsonperg = "";
        Perguntas perguntas = new Perguntas();
        Produtos produtos = new Produtos();
        List<string> selprods = new List<string>();

        public frmPergunta(string jsonprod, string jsonperg, List<string> produtos, Perguntas perguntas)
        {
            InitializeComponent();

            this.perguntas = perguntas;
            this.jsonprod = jsonprod;
            this.jsonperg = jsonperg;
            this.selprods = produtos;

            this.CarregarDadosProdutos();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public void CarregarDadosProdutos()
        {
            if (System.IO.File.Exists(this.jsonprod))
                this.produtos = new Produtos().Carregar(this.jsonprod);

            lstProdutos.Items.Clear();
            foreach (string prod in this.produtos.produtos)
            {
                ListViewItem sit = lstProdutos.Items.Add(prod, 0);
                sit.Checked = (selprods.Contains(prod));
            }
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            string retval = "";
            if (DialogResult.OK == new EasyInputs().InputTextBox("Novo Produto", "Informe o nome do Produto", "", ref retval))
            {
                if (!this.produtos.produtos.Contains(retval))
                    this.produtos.produtos.Add(retval);

                this.produtos.Salvar(jsonprod);
                this.CarregarDadosProdutos();
            }
        }

        private void lstProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAltProduto.Enabled = (lstProdutos.SelectedItems.Count > 0);
        }

        private void btnAltProduto_Click(object sender, EventArgs e)
        {
            if (lstProdutos.SelectedItems.Count > 0)
            {
                string produto = lstProdutos.SelectedItems[0].SubItems[0].Text;
                bool produtochecked = lstProdutos.SelectedItems[0].Checked;

                List<Pergunta> pergs = this.produtos.Onde_e_Usado(produto, this.perguntas);

                string retval = "";
                if (DialogResult.OK == new EasyInputs().InputTextBox("Alterar Produto", "Informe o nome do Produto", produto, ref retval))
                {
                    lstProdutos.SelectedItems[0].SubItems[0].Text = retval;

                    bool alterar = true;
                    if (pergs != null)
                        alterar = (DialogResult.Yes == MessageBox.Show("Esse Produto esta vinculado a outras perguntas, alterar mesmo assim?", 
                                                                       "Altera!",
                                                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                    if (alterar)
                    {
                        List<string> lstprods = new List<string>();
                        foreach (Pergunta perg in pergs)
                        {
                            foreach (string prod in perg.regra.produtos)
                                if (prod == produto) lstprods.Add(retval);
                                else lstprods.Add(prod);

                            perg.regra.produtos = lstprods;
                        }

                        this.perguntas.Salvar(this.jsonperg);
                        
                        

                        this.produtos.produtos.Clear();
                        foreach (ListViewItem it in lstProdutos.Items)
                            this.produtos.produtos.Add(it.SubItems[0].Text);

                        this.produtos.Salvar(jsonprod);
                        this.CarregarDadosProdutos();                        
                    }

                }


            }
        }
    }
}
