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
            if (tbInputFile.Text.Length > 1 & tbOutputFile.Text.Length > 1 )
            {
                var outputFormat = new reqformat();
                outputFormat.columnOrder[0] = "id";
                outputFormat.columnOrder[1] = "number";
                outputFormat.columnOrder[2] = "quote";

                var order = new List<int>();

                var fhh = new FileHelperEngine<recordHeader>();
                var inputh = fhh.ReadFile(tbInputFile.Text);

                recordHeader header = inputh[0];

                Console.WriteLine("File Headers:");
                Console.WriteLine(header.ID);
                Console.WriteLine(header.number);
                Console.WriteLine(header.alpha);
                Console.WriteLine(header.lz);
                Console.WriteLine(header.quote);
                Console.WriteLine(header.apo);

                for (int fieldNum = 0; fieldNum < outputFormat.columnOrder.GetLength(0); fieldNum++)
                {
                    Console.WriteLine("Column to find: " + fieldNum.ToString() + " - " + outputFormat.columnOrder[fieldNum]);
                    if (outputFormat.columnOrder[fieldNum] == header.ID)
                    {
                        Console.WriteLine(outputFormat.columnOrder[fieldNum] + " found");
                        order[fieldNum] = 0;
                    }
                    else if (outputFormat.columnOrder[fieldNum] == header.number)
                    {
                        Console.WriteLine(outputFormat.columnOrder[fieldNum] + " found");
                        order[fieldNum] = 1;
                    }
                    else if (outputFormat.columnOrder[fieldNum] == header.alpha)
                    {
                        Console.WriteLine(outputFormat.columnOrder[fieldNum] + " found");
                        order[fieldNum] = 2;
                    }
                    else if (outputFormat.columnOrder[fieldNum] == header.lz)
                    {
                        Console.WriteLine(outputFormat.columnOrder[fieldNum] + " found");
                        order[fieldNum] = 3;
                    }
                    else if (outputFormat.columnOrder[fieldNum] == header.quote)
                    {
                        Console.WriteLine(outputFormat.columnOrder[fieldNum] + " found");
                        order[fieldNum] = 4;
                    }
                    else if (outputFormat.columnOrder[fieldNum] == header.apo)
                    {
                        Console.WriteLine(outputFormat.columnOrder[fieldNum] + " found");
                        order[fieldNum] = 5;
                    }
                    else
                    {
                        Console.WriteLine("Not found");
                        order[fieldNum] = -1;
                    }
                }

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

[DelimitedRecord(",")]
public class recordHeader
{
    public string ID;
    public string number;
    public string alpha;
    public string lz;
    public string quote;
    public string apo;
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

public class reqformat
{
    public string[] columnOrder;
}
