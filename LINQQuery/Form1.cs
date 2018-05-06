using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQQuery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CdCollection.GetCDs();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.InitialDirectory = @"C:\Users\user\Documents\Visual Studio 2017\Projects\WinFormsHomeWorks\LINQQuery\bin\Debug";
            opf.Filter = "ALL XML FILES(*.xml) | *.xml";
            //if(opf.ShowDialog() == DialogResult.OK)
            //opf.FileName;
        }

        private void showCountriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.DataSource == CdCollection.GetCDs())
            {
                var countries = from cd in CdCollection.GetCDs() select cd.COUNTRY.ToArray();
                dataGridView1.DataSource = countries;
            }
        }
    }
}
