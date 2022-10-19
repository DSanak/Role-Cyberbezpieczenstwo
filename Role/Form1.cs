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
        //public static string type;
        public Form1()
        {

            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connection = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Users; Integrated Security = True";


            try
            {

                var cmd = "select * from tb_loginrole where username='"+textBox1.Text+"' and password='"+textBox2.Text+"' and isBlock != 'YES'" ;

                DataTable table = new DataTable();
                SqlDataAdapter adpt = new SqlDataAdapter(cmd, connection);
                adpt.Fill(table);

                if (table.Rows.Count == 1)
                {//to coś nie działa nie wiem jeszcze czemu
                    var cmd_PasswordExpire = "select dayToPasswordExpire from tb_loginrole where username ='" + textBox1.Text + "' and dayToPasswordExpire < 1";
                    DataTable dt3 = new DataTable();
                    new SqlDataAdapter(cmd_PasswordExpire, connection);
                    if (dt3.Rows.Count == 1)
                    {
                        MessageBox.Show(dt3.Rows.Count.ToString());
                        MessageBox.Show("Musisz zmienić swoje hasło! ");
                        this.Close();
                        new Register().Show();

                    }
                    else
                    {
                        DataTable dt2 = new DataTable();
                        var cmd_role = "select type from tb_loginrole where username='" + textBox1.Text + "' and type = 'U'";
                        SqlDataAdapter adpt2 = new SqlDataAdapter(cmd_role, connection);
                        adpt2.Fill(dt2);

                        if (dt2.Rows.Count == 1)
                        {
                            MessageBox.Show("Wlazles tu");
                            MyConnection.type = "U";
                        }
                        else MyConnection.type = "A";




                        MessageBox.Show($"Witaj " + textBox1.Text);

                        Dashboard d = new Dashboard();
                        d.Show();
                        this.Hide();
                    }
                }
                else MessageBox.Show("Try Agin");






                
                //   MessageBox.Show(dt2.Rows.Count.ToString());



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
