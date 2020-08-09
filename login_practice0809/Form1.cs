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

namespace login_practice0809
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LG\Documents\Data1.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from USERINFO where USERNAME='"+id_text.Text+"' and PASSWORD='"+pw_text.Text+"'", con);

            DataTable newTable = new DataTable();
            
            sda.Fill(newTable);

            if(newTable.Rows[0][0].ToString() == "1")
            {
                // 로그인 성공인 경우

       
            this.Hide();
                 
            Main_form mainForm1 = new Main_form();
            mainForm1.Show();
            }

            else
            {
                // 로그인 실패인 경우
                MessageBox.Show("아이디와 비번을 확인해주세요.");
            }


        }
    }
}
