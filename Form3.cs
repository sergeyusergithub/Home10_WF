using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home10_WF
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string FileName;

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;

                StreamReader sr = new StreamReader(FileName);

                string lines = "";

                while (!sr.EndOfStream)
                {
                    lines += sr.ReadLine() + Environment.NewLine;

                }

                txbMain.Text = lines;

                sr.Close();

            }

            btnEdit.Enabled = true;
        }

        public Form4 form4;

        private void btnEdit_Click(object sender, EventArgs e)
        {
      
            if ((form4 is null) || form4.Created)
            {
                form4 = new Form4(txbMain.Text,txbMain);
                form4.Show();
                form4.Owner = this;
                               
            }

            

        }
    }
}
