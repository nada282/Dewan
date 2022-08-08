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
using System.Drawing.Printing;


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
            StreamReader reader = new StreamReader("C:/Users/user/Desktop/TextFile1.txt");
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
                comboBoxDept.Items.Remove(item) ;
                
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
            CaptureScreen();
            PrintDocument printDocument1 = new PrintDocument();
            printDocument1.Print();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }

        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {

               listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                comboBoxDept.Items.Add(listBox1.SelectedItems);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
         comboBoxDept.Items.Clear();
        listBox1.Items.Clear();
        }
    }
}
