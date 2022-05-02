using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyRFI
{
    public partial class EasyRFI : Form
    {
        string jsonprod = @"C:\Users\langed\Desenv\EasyRFI\DB\Produtos.json";
        string jsonperg = @"C:\Users\langed\Desenv\EasyRFI\DB\Perguntas.json";
        string jsonader = @"C:\Users\langed\Desenv\EasyRFI\DB\Aderencia.json";

        Produtos produtos = new Produtos();
        Perguntas perguntas = new Perguntas();

        public DialogResult InputTextBox(string title, string promptText, string defaultvalue, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = (defaultvalue != "") ? defaultvalue : "";


            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 15, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.Font = new Font("Consolas", 10);
            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterParent;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        public void RegistrarMensagemdeErro(object sender, EventArgs e)
        {
            ErrorEventArgs errevarg = (ErrorEventArgs)e;
            string msg = errevarg.GetException().Message;

            MessageBox.Show(msg);          
        }

        public EasyRFI()
        {
            InitializeComponent();


            this.perguntas.eventError += new ErrorEventHandler(RegistrarMensagemdeErro);
            this.produtos.eventError += new ErrorEventHandler(RegistrarMensagemdeErro);

            this.CarregarDadosProdutos();
            this.CarregarDadosPerguntas();
        }

        public void CarregarDadosProdutos()
        {
            if (System.IO.File.Exists(jsonprod))
                this.produtos = new Produtos().Carregar(jsonprod);

            lstProdutos.Items.Clear();
            foreach (string prod in this.produtos.produtos)
                lstProdutos.Items.Add(prod, 0);
        }       

        public void CarregarDadosPerguntas()
        {
            if (System.IO.File.Exists(jsonperg))
                this.perguntas = new Perguntas().Carregar(jsonperg);

            //Vou popular uma linha para cada produto, dessa forma depois posso aplicar os filtros em cima da Listview direto
            lstPerguntas.Items.Clear();
            foreach (Pergunta perg in this.perguntas.perguntas)
                    foreach(string prod in perg.regra.produtos)
                    {
                        ListViewItem it = lstPerguntas.Items.Add(perg.pergunta, 0);
                        it.SubItems.Add(prod);
                        it.SubItems.Add(perg.regra.aderencia);
                        it.SubItems.Add(perg.regra.justificativa);
                    }
                
                
               
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            string retval = "";
            if (DialogResult.OK == this.InputTextBox("Novo Produto","Informe o nome do Produto", "", ref retval))
            {
                if (!this.produtos.produtos.Contains(retval))
                    this.produtos.produtos.Add(retval);

                this.produtos.Salvar(jsonprod);
                this.CarregarDadosProdutos();
            }
        }

        private void btnAddPergunta_Click(object sender, EventArgs e)
        {
            using (frmPergunta f = new frmPergunta())
            {
                //popular produtos
                f.lstProdutos.Items.Clear();
                foreach (string prod in this.produtos.produtos)
                    f.lstProdutos.Items.Add(prod);

                //popular aderencia
                Aderencia ader = new Aderencia().Carregar(jsonader);
                f.cmbAderencia.Items.Clear();
                foreach (string aderencia in ader.aderencia)
                    f.cmbAderencia.Items.Add(aderencia);

                if (f.cmbAderencia.Items.Count > 0)
                    f.cmbAderencia.SelectedIndex = 0;

                //------

                if (DialogResult.OK == f.ShowDialog(this))
                {
                    List<string> produtos = new List<string>();
                    foreach (ListViewItem it in f.lstProdutos.CheckedItems)
                        produtos.Add(it.Text);

                    try
                    {
                        bool segue = true;
                        Pergunta acheipergunta = this.perguntas.perguntas.Find(p => p.pergunta == f.txtPergunta.Text);
                        if (acheipergunta != null)
                            foreach (ListViewItem it in f.lstProdutos.CheckedItems)
                                if ((acheipergunta.regra.produtos.Count > 0) && (acheipergunta.regra.produtos.Contains(it.Text)))
                                    segue = false;

                        if (segue)
                        {
                            if (!ader.aderencia.Contains(f.cmbAderencia.Text))
                            {
                                ader.aderencia.Add(f.cmbAderencia.Text);
                                ader.Salvar(jsonader);
                            }

                            Regra reg = new Regra() { produtos = produtos, aderencia = f.cmbAderencia.Text, justificativa = f.txtJustificativa.Text };
                            Pergunta perg = new Pergunta() { pergunta = f.txtPergunta.Text, regra = reg };
                            this.perguntas.perguntas.Add(perg);
                            this.perguntas.Salvar(jsonperg);

                            this.CarregarDadosPerguntas();
                        }
                        else
                        {
                            throw new Exception("Pergunta Já existe para esse produto!!!");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
        }

        private void btnAltPergunta_Click(object sender, EventArgs e)
        {
            if (lstPerguntas.SelectedItems.Count > 0)
            {
                //só quero a primeira
                string pergunta = lstPerguntas.SelectedItems[0].SubItems[0].Text;
                string justificativa = lstPerguntas.SelectedItems[0].SubItems[3].Text;

                Pergunta perg = this.perguntas.perguntas.Find(p => p.pergunta == pergunta && p.regra.justificativa == justificativa);
                if ((perg != null) && (perg.regra.produtos.Count > 0) && (perg.regra.produtos.Contains(lstPerguntas.SelectedItems[0].SubItems[1].Text)))
                {
                    using (frmPergunta f = new frmPergunta())
                    {
                        f.txtPergunta.Text = perg.pergunta;

                        //popular produtos
                        f.lstProdutos.Items.Clear();
                        foreach (string prod in this.produtos.produtos)
                        {
                            ListViewItem sitem = f.lstProdutos.Items.Add(prod, 0);
                            sitem.Checked = (perg.regra.produtos.Contains(prod));
                        }

                        //popular aderencia
                        Aderencia ader = new Aderencia().Carregar(jsonader);
                        f.cmbAderencia.Items.Clear();
                        foreach (string aderencia in ader.aderencia)
                            f.cmbAderencia.Items.Add(aderencia);

                        f.cmbAderencia.Text = perg.regra.aderencia;
                        f.txtJustificativa.Text = perg.regra.justificativa;
                                
                        if (DialogResult.OK == f.ShowDialog(this))
                        {
                            if (!ader.aderencia.Contains(f.cmbAderencia.Text))
                            {
                                ader.aderencia.Add(f.cmbAderencia.Text);
                                ader.Salvar(jsonader);
                            }

                            List<string> produtos = new List<string>();
                            foreach (ListViewItem it in f.lstProdutos.CheckedItems)
                                produtos.Add(it.Text);

                            perg.regra.produtos = produtos;
                            perg.regra.aderencia = f.cmbAderencia.Text;
                            perg.regra.justificativa = f.txtJustificativa.Text;
                            perg.pergunta = f.txtPergunta.Text;

                            this.perguntas.Salvar(jsonperg);
                            this.CarregarDadosPerguntas();
                        }
                    }
                }
            }
        }

        private void lstPerguntas_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnAltPergunta.Enabled = (lstPerguntas.SelectedItems.Count > 0);
        }
    }

    
}
