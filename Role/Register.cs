using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
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


        public  string getHash(string text)
        {
            // SHA512 is disposable by inheritance.  
            using (var sha256 = SHA256.Create())
            {
                // Send a sample text to hash.  
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));
                // Get the hashed string.  
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }


        private void signup_button_Click(object sender, EventArgs e)
        {

            String pattern = @"^(?:(.)(?!\1{1}))+$";


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
                else if (Regex.IsMatch(reg_passwd.Text, pattern))
                {
                    MessageBox.Show(getHash(reg_passwd.Text));
                    
                    var register_cmd = "insert into tb_loginrole (name,username,password,type) values ('" + reg_username.Text + "','" + reg_username.Text + "','" + getHash(reg_passwd.Text) + "','U')";

                    SqlDataAdapter registeradpt = new SqlDataAdapter(register_cmd, connection);
                    registeradpt.Fill(table);
                    MessageBox.Show("Poprawna rejestracja");
                }
                else MessageBox.Show("Hasło powinno składać się z niepowtarzających haseł");











            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


    }
}

