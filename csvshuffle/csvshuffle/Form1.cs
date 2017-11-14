using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FileHelpers;

namespace csvshuffle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbInputFile_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = "c:\\";
            ofd.Filter = "csv files (*.csv)|*.csv|txt files (*.txt)|*.txt|All Files (*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;

            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                tbInputFile.Text = ofd.FileName;
            }
        }

        private void tbOutputFile_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = "c:\\";
            ofd.Filter = "csv files (*.csv)|*.csv|txt files (*.txt)|*.txt|All Files (*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;

            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                tbOutputFile.Text = ofd.FileName;
            }
        }

        private void btnProcess_MouseClick(object sender, MouseEventArgs e)
        {
            if(tbInputFile.Text.Length > 1 & tbOutputFile.Text.Length > 1 )
            {
                var fh = new FileHelperEngine<record>();
                var input = fh.ReadFile(tbInputFile.Text);

                foreach (record line in input)
                {
                    var tempList = new List<string>();
                    Console.WriteLine("Thing");
                    Console.WriteLine(line.ID);
                    Console.WriteLine(line.quote);

                    tempList[0] = line.ID.ToString();
                    tempList[1] = line.quote.ToString();

                    string[] outputLine = tempList.ToArray();
                }
            }
        }
    }
}

[DelimitedRecord(","), IgnoreFirst(1)]
public class record
{
    public int ID;
    public int number;
    public string alpha;
    public string lz;
    public string quote;
    public string apo;
}