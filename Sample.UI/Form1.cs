using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sample.DAO;

namespace Sample.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region ahdkhakdaksdhakshd
            //MessageBox.Show("Test");
            //txtName.BackColor = Color.Red;
            //this.BackColor = Color.Yellow;
            //Person p = new Person()
            //{
            //    Age="5",
            //    NameSurName="melike"
            //}; 
            #endregion


            Person p = new Person();
            p.Age = txtAge.Text;
            p.NameSurName = txtName.Text;

            DialogResult dg = MessageBox.Show(p.ToString(), "Bilgi", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                //diğer forma gonder
                Form2 f = new Form2(p);              
                f.Show();
            }
            else
            {
                //kullanıcıya bilgi ver:
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
