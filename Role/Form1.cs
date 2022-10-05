using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Role
{
    public partial class Form1 : Form
    {
        MyConnection db = new MyConnection();
        public Form1()
        {
            InitializeComponent();

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                    SqlCommand cmd = new SqlCommand("sp_Role_Login", db.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@uname", textBox1.Text);
                    cmd.Parameters.AddWithValue("@upass", textBox2.Text);
                  
                    db.con.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    if(rd.HasRows)
                    {
                        rd.Read();
                        if(rd[4].ToString()=="Admin")
                        {
                            MyConnection.type = "A";
                        }
                        else if (rd[4].ToString() == "User")
                        {
                            MyConnection.type = "U";
                        }
                        MessageBox.Show("Welcome " + textBox1.Text);

                        Dashboard d = new Dashboard();
                        d.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                    }

                    
                db.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }
    }
}
