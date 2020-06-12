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
    public partial class Horarios : Form
    {
        int id_usuario;

        public Horarios(int param)
        {
            id_usuario = param;
            InitializeComponent();
        }

        private void btn_Buscar(object sender, EventArgs e)
        {
            SqlConnection con;
            String query;
            SqlDataReader reader = null;

            con = Conexao.getConnection();
            query = "Select id_Oficina, Nome_Oficina, Endereco, CEP FROM Oficina";
            reader = Conexao.getQuery(query, con);

            while (reader.Read())
            {
                cbOficina.Items.Add("[" + reader["id_Oficina"] + "] - " + reader["Nome_Oficina"] + ", " + reader["Endereco"] + " cep: " + reader["CEP"]);
            }
            con.Close();

            con = Conexao.getConnection();
            query = "Select id_Cod_Servico, Data, Hora FROM Servico Where id_Oficina Is Null and id Is Null";
            reader = Conexao.getQuery(query, con);

            while (reader.Read())
            {
                cbhorario.Items.Add("[" + reader["id_Cod_Servico"] + "] - " + reader["Data"] + ", " + reader["Hora"]);
            }
            con.Close();


        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {

            SqlConnection con;
            String query;
            SqlDataReader reader = null;
            SqlCommand update = null;

            String oficina = cbOficina.GetItemText(cbOficina.SelectedItem);
            String horario = cbhorario.GetItemText(cbhorario.SelectedItem);

            int id_horario, id_oficina;
            char[] spearator = { '-', ' ' };
            Int32 count = 2;

            // Using the Method 
            String[] strlist;

            strlist = oficina.Split(spearator,
                   count, StringSplitOptions.None);
            
            oficina = strlist[0].Replace("[", "");
            oficina = oficina.Replace("]", "");
            id_oficina = Convert.ToInt16(oficina);


            strlist = horario.Split(spearator,
                   count, StringSplitOptions.None);
            horario = strlist[0].Replace("[", "");
            horario = horario.Replace("]", "");
            id_horario = Convert.ToInt16(horario);

           query = "Update Servico Set id_Oficina = '"+ id_oficina +"', id = '"+ id_usuario +"' Where id_Cod_Servico = '"+ horario +"'";           
           con = Conexao.getConnection();
           update = Conexao.setQuery(query, con);
           con.Close();
           MessageBox.Show("Agendamento Realizado com Sucesso");
           this.Close();
              

        }
    }
}
