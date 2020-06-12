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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
          
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            String query;
            SqlConnection con;
            SqlDataReader reader = null;
            SqlCommand insert = null;

            if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtCPF.Text) || String.IsNullOrEmpty(txtEmail.Text) ||
                String.IsNullOrEmpty(txtDatadeNascimento.Text) || String.IsNullOrEmpty(txtEndereço.Text) || String.IsNullOrEmpty(txtCelular.Text) ||
                String.IsNullOrEmpty(txtCEP.Text) || String.IsNullOrEmpty(txtUsuario.Text) || String.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Favor Preencher os Campos em Branco");
            }

            else
            {
                con = Conexao.getConnection();

                query = "Select usuario FROM Dados_Pessoais where usuario='" + txtUsuario.Text + "'";
                reader = Conexao.getQuery(query, con);

                while (reader.Read())
                {
                    MessageBox.Show("Usuario Ja Esta em Uso");
                }
                con.Close();
                con = Conexao.getConnection();

                query = "Select cpf FROM Dados_Pessoais where cpf='" + txtCPF.Text + "'";
                reader = Conexao.getQuery(query, con);

                while (reader.Read())
                {
                    MessageBox.Show("CPF Ja Esta em Uso");
                }

                con.Close();
                con = Conexao.getConnection();

                query = "Select email FROM Dados_Pessoais where email='" + txtEmail.Text + "'";
                reader = Conexao.getQuery(query, con);

                while (reader.Read())
                {
                    MessageBox.Show("Email Ja Esta em Uso");
                }

                con.Close();

                con = Conexao.getConnection();

                query = "Insert into Dados_Pessoais (" +
                "usuario,senha,cpf,email,celular,endereco,cep,complemento,nome,data_nasc) Values ('" +
                txtUsuario.Text + "','" + txtSenha.Text + "','" + txtCPF.Text + "','" + txtEmail.Text + "','" +
                txtCelular.Text + "','" + txtEndereço.Text + "','" + txtCEP.Text + "','" + txtComplemento.Text +
                "','" + txtNome.Text + "','" + txtDatadeNascimento.Text + "')";


                insert = Conexao.setQuery(query, con);
                con.Close();
                MessageBox.Show("Cadastro Realizado com Sucesso");
                this.Close();
            }
        }
    }
}
