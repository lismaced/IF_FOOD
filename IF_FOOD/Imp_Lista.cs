using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IF_FOOD
{
    public partial class w_Imp_Lista : Form
    {
        //List<Produto> l_Prod;
        List<string> Lista;


        public w_Imp_Lista()
        {
            InitializeComponent();
        }

        public w_Imp_Lista(List<string> L, string Tipo) : this()
        {
            this.Lista = L;
            this.Text += Tipo;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Imp_Lista_Load(object sender, EventArgs e)
        {
            //foreach (Produto P in this.l_Prod)
            foreach (string S in this.Lista)
            {
                //lb_Lista.Items.Add("Cód: "+P.Codigo + " Descr.:"+ P.Desc + " Qtde.:"+P.Qtde + " Preço: " +P.Preco);
                lb_Lista.Items.Add(S);
            }

        }

        private void lb_Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<Produto> L_Prod = new List<Produto>();
                List<string> L_ProdImp = new List<string>();
                ProdutoBD ProdBD = new ProdutoBD();

                L_Prod = ProdBD.ListarTodos();

                foreach (Produto P in L_Prod)
                {
                    L_ProdImp.Add("Cód: " + P.Codigo + " Descr.:" + P.Desc + " Qtde.:" + P.Qtde + " Preço: " + P.Preco);
                }

                w_Imp_Lista w_Imp = new w_Imp_Lista(L_ProdImp, "Produtos");
                w_Imp.ShowDialog();
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Não foi possível carregar os produtos do Oracle ({ex.Number}):\n{ex.Message}",
                                "Erro de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado ao listar produtos:\n{ex.Message}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
