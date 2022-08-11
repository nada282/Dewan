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
        public static MainForm instance;
       
        public MainForm()
        {
            InitializeComponent();
            instance=this;
           
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
                int Last = line.LastIndexOf(',');
                string modria = line.Substring(Last+1);
                comboBoxDept.Items.Add(name+"_"+modria);
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
 master
            int count = 0;
            string[] st=null;
             
            Form2 form2=new Form2();
            string[] arr = new string[listBox1.Items.Count];

            if (listBox1.Items.Count >= 1)
            {
                string[] FirstDept = listBox1.Items[0].ToString().Split('_');
                form2.label8.Text = FirstDept[0];
                form2.id_1.Text = FirstDept[1];
                form2.label38.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }
            if (listBox1.Items.Count>=2)
            {
                string[] dept = listBox1.Items[1].ToString().Split('_');
                form2.label12.Text = dept[0];
                form2.label11.Text = dept[1];
                form2.label39.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }
            if (listBox1.Items.Count >= 3)
            {
                string[] dept = listBox1.Items[2].ToString().Split('_');
                form2.label20.Text = dept[1];
                form2.label21.Text = dept[0];
                form2.label40.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }
            if (listBox1.Items.Count >= 4)
            {
                string[] dept = listBox1.Items[3].ToString().Split('_');
                form2.label29.Text = dept[1];
                form2.label30.Text = dept[0];
              form2.label41.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }

            form2.Show();
            ////////////////////////////////////////

            
            
        







        /////////////////////////////////
        //object item = listBox1.SelectedItem;
        //    string s = item.ToString();
        //   string  [] st= s.Split('_');
          
        //        Form2.instance.label.Text = "  :المرسل اليه   " + st[0];
        //    Form2.instance.Label1.Text = st[1] +"  :الرمز البريدي     ";

        //    //   Form2.instance.label.Text = "  :المرسل اليه   " + s.Split('_');

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
 master
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
