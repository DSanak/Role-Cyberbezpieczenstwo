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
    public partial class Managment : Form
    {
        string connection = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Users; Integrated Security = True";

        public Managment()
        {
            InitializeComponent();
        }

        

        private void bt_userList_Click(object sender, EventArgs e)
        {
            try
            {
                var cmd = "select * from tb_loginrole";
                //SqlCommand cmd = new SqlCommand("select * from tb_loginrole", db.con);
                //cmd.CommandType = CommandType.Text;


                DataTable table = new DataTable();

                SqlDataAdapter adpt = new SqlDataAdapter(cmd, connection);
                adpt.Fill(table);
                dataGridView1.DataSource = table;


                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var cmd = "delete from tb_loginrole where id=" + idtxt.Text;
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(idtxt.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter only numbers.");
                    idtxt.Text = idtxt.Text.Remove(idtxt.Text.Length - 1);
                }
                else
                {



                    DataTable table = new DataTable();

                    SqlDataAdapter adpt = new SqlDataAdapter(cmd, connection);
                    adpt.Fill(table);
                    dataGridView1.DataSource = table;

                    MessageBox.Show("User o id " + idtxt.Text + " został usunięty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }

        private void btn_blockUser_Click(object sender, EventArgs e)
        {
            var cmd = "UPDATE tb_loginrole SET isBlock = 'YES' where Id="+ idtxt.Text;
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(idtxt.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter only numbers.");
                    idtxt.Text = idtxt.Text.Remove(idtxt.Text.Length - 1);
                }
                else
                {



                    DataTable table = new DataTable();

                    SqlDataAdapter adpt = new SqlDataAdapter(cmd, connection);
                    adpt.Fill(table);
                    dataGridView1.DataSource = table;

                    MessageBox.Show("User o id " + idtxt.Text + " został zablokowany");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
              this.Close();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            new ChnagePassword().Show();

        }

        private void btnSetDayPasswordExpiers_Click(object sender, EventArgs e)
        {

            if (idtxt.Text.Length < 0 )
            {
                   MessageBox.Show("Podaj id konta");
              
            }else
            {
                var cmdSetPasswordDay = "UPDATE tb_loginrole SET dayToPasswordExpire = " + list_day.Text + " where Id=" + idtxt.Text + "";

                DataTable table = new DataTable();

                SqlDataAdapter adpt = new SqlDataAdapter(cmdSetPasswordDay, connection);
                adpt.Fill(table);

                MessageBox.Show("Wykonane :)");
            }
          
        }
    }
}
