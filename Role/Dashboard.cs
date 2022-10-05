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
    public partial class Dashboard : Form
    {
        
        public Dashboard()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            


            if (MyConnection.type == "A")
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
            }
            else if (MyConnection.type == "U")
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = true;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                var connection = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Users; Integrated Security = True";
                var cmd = "select * from tb_loginrole";
                //SqlCommand cmd = new SqlCommand("select * from tb_loginrole", db.con);
                //cmd.CommandType = CommandType.Text;
                

                DataTable table = new DataTable();

                SqlDataAdapter adpt = new SqlDataAdapter(cmd,connection);
                adpt.Fill(table);
                dataGridView1.DataSource = table;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
