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

namespace lecture_09_recap
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string name=textBoxname.Text;
            string password=textBoxpassword.Text;
            string confirmpassword=textBoxconfirmpassword.Text;
            string dob=dateTimePicker1.Value.ToString("yyyy-MM-dd");

            //creating the sql query
            string query = "INSERT INTO Student(Name,dob,password) VALUES ('{name}','{dob}','{password}');";
            SqlCommand cmd = new SqlCommand(query,con1);

            //excecution of the command
            try
            {
                con1.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successful data entry!");
                con1.Close(); //to re-enter data without exceptions
            }
            catch(SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
        }
    }
}
