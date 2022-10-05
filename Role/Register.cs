using System;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace Role
{
    public partial class Register : Form
    {
        readonly MyConnection db = new MyConnection();

        public Register()
        {
            InitializeComponent();
        }

        private void signup_button_Click(object sender, EventArgs e)
        {

            try
            {
                var connection = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Users; Integrated Security = True";
                var cmd = "select * from tb_loginrole where username='" + reg_username.Text + "'";

                DataTable table = new DataTable();
                SqlDataAdapter adpt = new SqlDataAdapter(cmd, connection);
                adpt.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Podany uzytkownik już istnieje!");
                }
                else
                {
                    var register_cmd = "insert into tb_loginrole (name,username,password,type) values ('" + reg_username.Text + "','" + reg_username.Text + "','" + reg_passwd.Text + "','U')";

                    SqlDataAdapter registeradpt = new SqlDataAdapter(register_cmd, connection);
                    registeradpt.Fill(table);
                    MessageBox.Show("Poprawna rejestracja");
                }


                //              cmd.Parameters.AddWithValue("@uname", reg_username.Text);
                //              cmd.Parameters.AddWithValue("@upass", reg_passwd.Text);









            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


    }
}

