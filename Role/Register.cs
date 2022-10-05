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
               
                    SqlCommand cmd = new SqlCommand("select * from tb_loginrole", db.con);
                    db.con.Open();
                    cmd.Parameters.AddWithValue("@uname", reg_username.Text);
                    cmd.Parameters.AddWithValue("@upass", reg_passwd.Text);

                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                    rd.Read();
                        if (rd[3].ToString() == reg_username.Text)
                        {
                            MessageBox.Show("Taki user juz istnieje");
                        
                        }
                        else if (reg_passwd.Text.Length < 5)
                        {
                            MessageBox.Show("Za krótkie haslo");
                        }
                        else
                        {
                        rd.Close();
                            SqlCommand register_cmd = new SqlCommand("insert into tb_loginrole (name,username,password,type) values ('" + reg_username.Text + "','" + reg_username.Text + "','" + reg_passwd.Text + "','U')", db.con);
                            register_cmd.ExecuteNonQuery();

                            MessageBox.Show("Poprawna rejestracja");
                            MessageBox.Show(rd[3].ToString());


                    }

                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            db.con.Close();
        }


    }
}

