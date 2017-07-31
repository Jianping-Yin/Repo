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

namespace DragAndDrop1
{
    public partial class AutoAnalysis : Form
    {
        string[] files;
        public AutoAnalysis()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;

        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string file in files)
                filesBox.Items.Add(file);
            label1.Text = filesBox.Items.Count.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            filesBox.Items.Clear();
            label1.Text = filesBox.Items.Count.ToString();
        }

        private void diagnosis_Click(object sender, EventArgs e)
        {
            string[] strings = new string[20];
            using (var reader = new StreamReader(files[0]))  
            {
                int transOilPreCount1=0;
                int k;
                var csv = new StringBuilder();
                var headline = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    // k = Convert.ToInt32(values[8]);

                    if (k>270 ||k<100) //trans oil press out of range
                    {
                       csv.AppendLine(line);  //add a line
                        transOilPreCount1 ++ ;
                    }
                }
                File.WriteAllText(@"C:\Test\result.csv", csv.ToString());  //save at C:\Test\result.csv
                transOilPreCount.Text = transOilPreCount1.ToString();             

            }
        }


    }
}
