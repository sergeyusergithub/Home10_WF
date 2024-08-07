using System.ComponentModel;

namespace Home10_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DestEmpty();
            SourceEmpty();

            pgValue();
        }

        private void btnClearDest_Click(object sender, EventArgs e)
        {
            lstDest.Items.Clear();

            pgValue();
            DestEmpty();
        }

        private void btnAddDest_Click(object sender, EventArgs e)
        {
            if (chbDelSource.Checked)
            {

                MoveItems(lstSource, lstDest);

            }
            else
            {
                for (int i = 0; i < lstSource.SelectedItems.Count; i++)
                {
                    lstDest.Items.Add(lstSource.SelectedItems[i]);
                }
            }

            pgValue();
            DestEmpty();
            SourceEmpty();


        }

        private void btnAddDestAll_Click(object sender, EventArgs e)
        {
           
            lstDest.Items.AddRange(lstSource.Items);
            if (chbDelSource.Checked)
            {

                lstSource.Items.Clear();

            }

            pgValue();
            DestEmpty();
            SourceEmpty();


        }



        private void btnAddSource_Click(object sender, EventArgs e)
        {
            if (chbDelSource.Checked)
            {

                MoveItems(lstDest, lstSource);

            }
            else
            {
                for (int i = 0; i < lstDest.SelectedItems.Count; i++)
                {
                    lstSource.Items.Add(lstDest.SelectedItems[i]);
                }
            }

            pgValue();
            DestEmpty();
            SourceEmpty();

        }

        private void btnAddSourceAll_Click(object sender, EventArgs e)
        {
            lstSource.Items.AddRange(lstDest.Items);
            if (chbDelSource.Checked)
            {

                lstSource.Items.Clear();

            }
            pgValue();
            DestEmpty();
            SourceEmpty();
        }

        private void pgValue()
        {


            int p = lstSource.Items.Count;

            if (p > 100) { p = 100; }

            pbSource.Value = (p * 100) / (lstSource.Items.Count < lstDest.Items.Count ? lstDest.Items.Count : lstSource.Items.Count); ;

            p = lstDest.Items.Count;
            if (p > 100) { p = 100; }
            pbDest.Value = (p * 100) / (lstSource.Items.Count < lstDest.Items.Count ? lstDest.Items.Count : lstSource.Items.Count); ;
        }


        private void MoveItems(ListBox Source, ListBox Dest)
        {
            for (int i = 0; i < Source.SelectedItems.Count;)
            {
                Dest.Items.Add(Source.SelectedItems[i]);
                Source.Items.Remove(Source.SelectedItems[i]);

            }


        }

        private void DestEmpty()
        {
            if (lstDest.Items.Count == 0)
            {
                btnAddSource.Enabled = false;
                btnAddSourceAll.Enabled = false;
                btnClearDest.Enabled = false;
            }
            else
            {
                btnAddSource.Enabled = true;
                btnAddSourceAll.Enabled = true;
                btnClearDest.Enabled = true;
            }

        }

        private void SourceEmpty()
        {

            if (lstSource.Items.Count == 0)
            {
                btnAddDest.Enabled = false;
                btnAddDestAll.Enabled = false;
            }
            else
            {
                btnAddDest.Enabled = true;
                btnAddDestAll.Enabled = true;

            }
        }

        public Form2 form2;

        private void btnForm2_Click(object sender, EventArgs e)
        {
            if ((form2 is null) || (!form2.Created))
            {
                form2 = new Form2(lstDest);
                form2.Show();
            }


        }

        public Form3 form3;

        private void btnTask2_Click(object sender, EventArgs e)
        {
            if((form3 is null) || (!form3.Created))
            {
                form3 = new Form3();
                form3.Show();
            }

        }
    }

}
