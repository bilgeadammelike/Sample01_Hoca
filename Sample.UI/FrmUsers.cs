using Sample.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample.UI
{
    public partial class FrmUsers : Form
    {
        public FrmUsers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validate
            //hata kontrolu
            //forma gonderme
            if (KontrolEt()==true)
            {

            }
            else
            {
                MessageBox.Show("hata var");
            }

        }
        //validate
        private bool KontrolEt()
        {
            //
            //foreach (Control item in this.Controls)
            //{
            //    if (item is TextBox)
            //    {
            //        TextBox t = item as TextBox;
            //        t.BackColor = Color.Red;

            //    }

            //} 
            if (maskedTextBox1.Text.Count()==11)
            {
                
            }

            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            Yukle();
        }     

        private void Yukle()
        {
            comboBox1.Items.Add("izmir");
            comboBox1.Items.Add("ankara");
            comboBox1.Items.Add("istanbul");
            rdpKadin.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
