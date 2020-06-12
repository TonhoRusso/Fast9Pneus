using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fast9Pneus
{
    public partial class Fast9Pneus : Form
    {
        string con = ("Data Source=DESKTOP-3I5D8M1\\SQLEXPRESS;Initial Catalog=Fast9Pneus;Integrated Security=true");
        public Fast9Pneus()
        {
            InitializeComponent();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "" && txt_senha.Text == "")
            {
                MessageBox.Show("Por Favor, se Registre")
            }


        }
    }
}
