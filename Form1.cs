using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Hotel1
{
    public partial class Form1 : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlConnection con;

        

        public Form1()
        {
            
            InitializeComponent();
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=laptop-rj7cem4l\\sqlexpress;Initial Catalog=Room;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Insert into Email(EmailAddress,RoomType,NumberofGuests) Values(@EmailAddress,@RoomType,@NumberofGuests)", con);
            cmd.Parameters.Add("@EmailAddress", Email.Text);
            cmd.Parameters.Add("@RoomType", comboBox1.SelectedItem.ToString());
            cmd.Parameters.Add("@NumberofGuests", comboBox2.SelectedItem.ToString());
            
            
            cmd.ExecuteNonQuery();

            

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            MessageBox.Show("Reservation Code: " + finalString,"Save the code",MessageBoxButtons.OK,MessageBoxIcon.Information);

           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
    

    }

    

