
namespace IF_FOOD
{
    public partial class w_Principal : Form
    {
        /*List<Produto> l_Prod = new List<Produto>();
        List<Pedido> l_Ped = new List<Pedido>();*/

        public w_Principal()
        {
            InitializeComponent();
        }

        private void w_Principal_Load(object sender, EventArgs e)
        {

        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {          

        }

        private void btn_Vendas_Click(object sender, EventArgs e)
        {
            w_Lista_Pedidos w_L_Ped = new w_Lista_Pedidos(/*l_Prod, l_Ped*/);

            w_L_Ped.ShowDialog();

        }

        private void btn_EntrarAdm_Click(object sender, EventArgs e)
        {
            string filtroU = "'%" + tb_U.Text + "'%";
            string filtroS = "'%" + tb_U.Text + "'%";
            string SQL = "SELECT * FROM G6_USUARIOS WHERE NOME LIKE " +filtroU+ " AND SENHA LIKE" +filtroS;

            
            w_Imp_Lista w_Lista = new w_Imp_Lista();
            w_Lista.ShowDialog();
        }
    }
}
