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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public TextBox textBoxMain;

        public Form4(string Text, object obj)
        {
            InitializeComponent();
            txtBoxEdit.Text = Text;
            textBoxMain = (obj as TextBox);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            (this.Owner as Form3).form4 = null;
            this.Close();            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            textBoxMain.Text = txtBoxEdit.Text;
            (this.Owner as Form3).form4 = null;
            this.Close();  
        }
    }
}
