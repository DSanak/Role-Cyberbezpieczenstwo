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
            var connection = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Users; Integrated Security = True";


            try
            {

                var cmd = "select * from tb_loginrole where username='"+textBox1.Text+"' and password='"+textBox2.Text+"' and isBlock != 'YES'" ;

                DataTable table = new DataTable();
                SqlDataAdapter adpt = new SqlDataAdapter(cmd, connection);
                adpt.Fill(table);

                if (table.Rows.Count ==1)
                {
                    MessageBox.Show("Witaj ");

                    Dashboard d = new Dashboard();
                    d.Show();
                    this.Hide();
                }
                else MessageBox.Show("Try Agin");

                
               


               
                
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
