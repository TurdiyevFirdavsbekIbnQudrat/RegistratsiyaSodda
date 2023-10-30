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

namespace Registratsiya
{
    public partial class YangiUser : Form
    {
        public YangiUser()
        {
            InitializeComponent();
        }

        private void malumotQoshish_button_Click(object sender, EventArgs e)
        {
            bool ozgargan = true;
            if(textBox_yangiEmail.Text.Length==0) ozgargan=false;
            if (textBox_yangiFamiliya.Text.Length == 0) ozgargan = false;
            if (textBox_yangIsm.Text.Length == 0) ozgargan = false;
            if (textBox_yangiUserName.Text.Length == 0) ozgargan = false;
            if(textBox_yangiParol.Text.Length==0) ozgargan = false;
            
            if (ozgargan == true)
            {

                using (SqlConnection connect = new SqlConnection())
                {
                    connect.ConnectionString = "Server = DESKTOP-HUHB6EP; Database = Birinchi_ish; Trusted_Connection=true;";
                    connect.Open();

                    string query = $"insert into Regist Values('{textBox_yangiEmail.Text}','{textBox_yangIsm.Text}','{textBox_yangiFamiliya.Text}','{textBox_yangiUserName.Text}','{textBox_yangiParol.Text}')";
                    SqlCommand sqlcommand = new SqlCommand(query, connect);
                    int rowsAffected = sqlcommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        MessageBox.Show("Qo'shildi");
                    else
                        MessageBox.Show("Qo'shilmadi");
                }
            }
            else
            {
                MessageBox.Show("Har bir qatorda malumot bo'lishi shart");
            }

        }
    }
}
