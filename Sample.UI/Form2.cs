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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int a) : this()
        {

        }
        public Form2(Person p) : this(4)
        {
            listBox1.Items.Add(p);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person secilenPerson = (Person)listBox1.SelectedItem;
            MessageBox.Show(secilenPerson.Bolum);
        }
    }
}
