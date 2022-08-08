using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dewan
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("C:/Users/Bessan/Desktop/Dewan1-master/TextFile1.txt");
            StringBuilder builder = new StringBuilder();
            string line = reader.ReadLine();
            while (line != null)
            {
                int first = line.IndexOf(',');
                string name = line.Substring(0, first);
                comboBoxDept.Items.Add(name);
                line = reader.ReadLine();
            }
        }

        private void comboBoxDept_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          
            if(listBox1.Items.Count < 4) {

                object item = comboBoxDept.SelectedItem;
                listBox1.Items.Add(item)  ;
                
               }
            else { 
                string message = " !!!! لقد تجاوزت الحد المسموح ";
                MessageBox.Show(message);
        }

}
        private void textBoxdata_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {

                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}
