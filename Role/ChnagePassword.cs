using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Role
{
    public partial class ChnagePassword : Form
    {
        public ChnagePassword()
        {
            InitializeComponent();
        }

        private void btnConfirmPass_Click(object sender, EventArgs e)
        {
            var connection = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Users; Integrated Security = True";
           

            String pattern = @"^(?:(.)(?!\1{1}))+$";
            //  Regex rg = new Regex(pattern);
            if ((Regex.IsMatch(txtAdminPass.Text, pattern)) & txtAdminPass.Text == txtAdminPass2.Text)
            {
                var newPasswd = new Register().getHash(txtAdminPass.Text);


                var cmdChangePassword = "Update tb_loginrole set password ='" + newPasswd + "' where id = 1";

                DataTable table = new DataTable();
                SqlDataAdapter adpt = new SqlDataAdapter(cmdChangePassword, connection);
                adpt.Fill(table);
                MessageBox.Show(newPasswd);
                MessageBox.Show("Hasło zmieniono poprawnie");
            }
            else MessageBox.Show("Podane hasła różnią się bądź występuje powtórzenie znaku w haśle");

       
        }
    }
}
