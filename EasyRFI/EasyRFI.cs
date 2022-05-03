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

        Perguntas perguntas = new Perguntas();

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
            this.CarregarDadosPerguntas();
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


            dtPerguntas.Rows.Clear();
            foreach (Pergunta perg in this.perguntas.perguntas)
                foreach (string prod in perg.regra.produtos)
                {
                    dtPerguntas.Rows.Add(perg.pergunta, prod, perg.regra.aderencia, perg.regra.justificativa);
                }




        }

        private void NovaPergunta(string txtPergunta, List<string>lstProdutos, string txtAderencia, string txtJustificativa)
        {
            try
            {
                //vou verificar se existe alguma pergunta igual já cadastrada
                Pergunta acheipergunta = this.perguntas.perguntas.Find(p => p.pergunta == txtPergunta);
                bool segue = true;
                if (acheipergunta != null)
                    foreach (string strProd in lstProdutos)
                        //vou verificar se a mesma pergunta já esta cadastrada para o mesmo produto.
                        //posso ter a mesma pergunta para mais de 1 produto
                        if ((acheipergunta.regra.produtos.Count > 0) && (acheipergunta.regra.produtos.Contains(strProd)))
                            segue = false;

                if (segue)
                {
                    //Se o produto ainda não existe no json, adiciono ele
                    Produtos produtos = new Produtos();
                    if (System.IO.File.Exists(this.jsonprod))
                        produtos = new Produtos().Carregar(this.jsonprod);
                    foreach (string txtProduto in lstProdutos)
                        if ((txtProduto.Trim().Length > 0) && (!produtos.produtos.Contains(txtProduto)))
                        {
                            produtos.produtos.Add(txtProduto);
                            produtos.Salvar(this.jsonprod);
                        }

                    //Se a aderencia não existe ainda no json, adiciona ela
                    Aderencia aderencia = new Aderencia();
                    if (System.IO.File.Exists(this.jsonader))
                        aderencia = new Aderencia().Carregar(this.jsonader);
                    if ((txtAderencia.Trim().Length > 0) && (!aderencia.aderencia.Contains(txtAderencia)))
                    {
                        aderencia.aderencia.Add(txtAderencia);
                        aderencia.Salvar(this.jsonader);
                    }

                    //agora vou criar o objeto da regra e a pergunta
                    Regra reg = new Regra() { produtos = lstProdutos, aderencia = txtAderencia, justificativa = txtJustificativa };
                    Pergunta perg = new Pergunta() { pergunta = txtPergunta, regra = reg };
                    this.perguntas.perguntas.Add(perg);
                    this.perguntas.Salvar(jsonperg);
                }

                this.CarregarDadosPerguntas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddPergunta_Click(object sender, EventArgs e)
        {
            using (frmPergunta f = new frmPergunta(this.jsonprod, this.jsonperg, new List<string>(), this.perguntas))
            {
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

                    List<string> lstProdutos = new List<string>();
                    foreach (ListViewItem it in f.lstProdutos.CheckedItems)
                        lstProdutos.Add(f.txtPergunta.Text);

                    this.NovaPergunta(f.txtPergunta.Text, lstProdutos, f.cmbAderencia.Text, f.txtJustificativa.Text);
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
                    using (frmPergunta f = new frmPergunta(this.jsonprod,this.jsonperg, perg.regra.produtos, this.perguntas))
                    {
                        f.txtPergunta.Text = perg.pergunta;

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

            btnAltPergunta.Enabled = btnDelPergunta.Enabled = (lstPerguntas.SelectedItems.Count > 0);
        }

        private void btnImportarCSV_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opdlg = new OpenFileDialog())
            {
                opdlg.Filter = "Arquivo CSV|*.csv";
                if (DialogResult.OK == opdlg.ShowDialog())
                {
                    Produtos produtos = new Produtos();
                    if (System.IO.File.Exists(this.jsonprod))
                        produtos = new Produtos().Carregar(this.jsonprod);

                    Aderencia aderencia = new Aderencia();
                    if (System.IO.File.Exists(this.jsonader))
                        aderencia = new Aderencia().Carregar(this.jsonader);

                    StreamReader sread = new StreamReader(opdlg.FileName, Encoding.Default);

                    int linenr = 0,
                        colpergunta = -1,
                        colProduto = -1,
                        colAderencia = -1,
                        colJustificativa = -1;
                    while (!sread.EndOfStream)
                    {
                        string[] arrayline = sread.ReadLine().Split(';');

                        if (arrayline.Length >= 4)
                            if (linenr == 0) //header
                            {
                                for (int i = 0; i < arrayline.Length; i++)
                                {
                                    switch (arrayline[i].ToLower().Trim())
                                    {
                                        case "pergunta": colpergunta = i; break;
                                        case "produto": colProduto = i; break;
                                        case "aderencia": colAderencia = i; break;
                                        case "justificativa": colJustificativa = i; break;
                                    }
                                }
                            }
                            else //dados
                            {
                                if (colpergunta == -1) throw new Exception("Não encontrei a coluna 'pergunta'");
                                if (colProduto == -1) throw new Exception("Não encontrei a coluna 'produto'");
                                if (colAderencia == -1) throw new Exception("Não encontrei a coluna 'aderencia'");
                                if (colJustificativa == -1) throw new Exception("Não encontrei a coluna 'justificativa'");

                                if (!produtos.produtos.Contains(arrayline[colProduto]))
                                {
                                    produtos.produtos.Add(arrayline[colProduto]);
                                    produtos.Salvar(this.jsonprod);
                                }

                                if ((arrayline[colpergunta].Trim().Length > 0) &&
                                    (arrayline[colProduto].Trim().Length > 0))
                                    this.NovaPergunta(arrayline[colpergunta], 
                                                      new List<string>() { arrayline[colProduto] },
                                                      (arrayline[colAderencia].Trim().Length > 0? arrayline[colAderencia]: "Não Aderente"),
                                                      arrayline[colJustificativa]);
                            }
                        linenr++;
                    }
                    sread.Close();
                }
            }
        }
    }

    
}
