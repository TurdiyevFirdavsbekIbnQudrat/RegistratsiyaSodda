using System.Data.SqlClient;
using System.Runtime.InteropServices.Marshalling;

namespace Registratsiya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_kirish_Click(object sender, EventArgs e)
        {

            using (SqlConnection connect = new SqlConnection())
            {
                connect.ConnectionString = "Server = DESKTOP-HUHB6EP; Database = Birinchi_ish; Trusted_Connection=true;";
                connect.Open();

                string query = $"select * from Regist where email='{textBox_eskiLogin.Text}' and parol = '{textBox_eskiniParoli.Text}'";
                SqlCommand sqlcommand = new SqlCommand(query, connect);
                string s = "";
                using (SqlDataReader reader = sqlcommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        s += reader;
                    }
                }
                if (s.Length>0) { MessageBox.Show("Ha siz bizda borsiz"); }
                else MessageBox.Show("Login yoki parol xato");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           var newData = new YangiUser();
            newData.Show();
        }
    }
}