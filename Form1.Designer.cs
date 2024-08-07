namespace Home10_WF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstSource = new ListBox();
            lstDest = new ListBox();
            btnAddDest = new Button();
            btnAddDestAll = new Button();
            btnAddSource = new Button();
            btnAddSourceAll = new Button();
            chbDelSource = new CheckBox();
            btnForm2 = new Button();
            pbSource = new ProgressBar();
            pbDest = new ProgressBar();
            btnClearDest = new Button();
            btnTask2 = new Button();
            SuspendLayout();
            // 
            // lstSource
            // 
            lstSource.FormattingEnabled = true;
            lstSource.ItemHeight = 15;
            lstSource.Items.AddRange(new object[] { "физика", "химия", "математика", "черчение", "музыка" });
            lstSource.Location = new Point(12, 12);
            lstSource.Name = "lstSource";
            lstSource.SelectionMode = SelectionMode.MultiExtended;
            lstSource.Size = new Size(149, 349);
            lstSource.TabIndex = 0;
            // 
            // lstDest
            // 
            lstDest.FormattingEnabled = true;
            lstDest.ItemHeight = 15;
            lstDest.Location = new Point(258, 12);
            lstDest.Name = "lstDest";
            lstDest.SelectionMode = SelectionMode.MultiExtended;
            lstDest.Size = new Size(166, 349);
            lstDest.TabIndex = 1;
            // 
            // btnAddDest
            // 
            btnAddDest.Location = new Point(191, 24);
            btnAddDest.Name = "btnAddDest";
            btnAddDest.Size = new Size(40, 25);
            btnAddDest.TabIndex = 2;
            btnAddDest.Text = "->";
            btnAddDest.UseVisualStyleBackColor = true;
            btnAddDest.Click += btnAddDest_Click;
            // 
            // btnAddDestAll
            // 
            btnAddDestAll.Location = new Point(191, 67);
            btnAddDestAll.Name = "btnAddDestAll";
            btnAddDestAll.Size = new Size(40, 25);
            btnAddDestAll.TabIndex = 3;
            btnAddDestAll.Text = "->>";
            btnAddDestAll.UseVisualStyleBackColor = true;
            btnAddDestAll.Click += btnAddDestAll_Click;
            // 
            // btnAddSource
            // 
            btnAddSource.Location = new Point(191, 156);
            btnAddSource.Name = "btnAddSource";
            btnAddSource.Size = new Size(40, 25);
            btnAddSource.TabIndex = 4;
            btnAddSource.Text = "<-";
            btnAddSource.UseVisualStyleBackColor = true;
            btnAddSource.Click += btnAddSource_Click;
            // 
            // btnAddSourceAll
            // 
            btnAddSourceAll.Location = new Point(191, 199);
            btnAddSourceAll.Name = "btnAddSourceAll";
            btnAddSourceAll.Size = new Size(40, 25);
            btnAddSourceAll.TabIndex = 5;
            btnAddSourceAll.Text = "<<-";
            btnAddSourceAll.UseVisualStyleBackColor = true;
            btnAddSourceAll.Click += btnAddSourceAll_Click;
            // 
            // chbDelSource
            // 
            chbDelSource.AutoSize = true;
            chbDelSource.Location = new Point(501, 28);
            chbDelSource.Name = "chbDelSource";
            chbDelSource.Size = new Size(146, 19);
            chbDelSource.TabIndex = 6;
            chbDelSource.Text = "Удалить из источника";
            chbDelSource.UseVisualStyleBackColor = true;
            // 
            // btnForm2
            // 
            btnForm2.Location = new Point(501, 67);
            btnForm2.Name = "btnForm2";
            btnForm2.Size = new Size(146, 25);
            btnForm2.TabIndex = 7;
            btnForm2.Text = "Открыть окно";
            btnForm2.UseVisualStyleBackColor = true;
            btnForm2.Click += btnForm2_Click;
            // 
            // pbSource
            // 
            pbSource.Location = new Point(12, 394);
            pbSource.Name = "pbSource";
            pbSource.Size = new Size(149, 33);
            pbSource.TabIndex = 8;
            // 
            // pbDest
            // 
            pbDest.Location = new Point(258, 394);
            pbDest.Name = "pbDest";
            pbDest.Size = new Size(166, 33);
            pbDest.TabIndex = 9;
            // 
            // btnClearDest
            // 
            btnClearDest.Location = new Point(191, 321);
            btnClearDest.Name = "btnClearDest";
            btnClearDest.Size = new Size(40, 23);
            btnClearDest.TabIndex = 10;
            btnClearDest.Text = "C";
            btnClearDest.UseVisualStyleBackColor = true;
            btnClearDest.Click += btnClearDest_Click;
            // 
            // btnTask2
            // 
            btnTask2.Location = new Point(501, 138);
            btnTask2.Name = "btnTask2";
            btnTask2.Size = new Size(140, 26);
            btnTask2.TabIndex = 11;
            btnTask2.Text = "Задание2";
            btnTask2.UseVisualStyleBackColor = true;
            btnTask2.Click += btnTask2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTask2);
            Controls.Add(btnClearDest);
            Controls.Add(pbDest);
            Controls.Add(pbSource);
            Controls.Add(btnForm2);
            Controls.Add(chbDelSource);
            Controls.Add(btnAddSourceAll);
            Controls.Add(btnAddSource);
            Controls.Add(btnAddDestAll);
            Controls.Add(btnAddDest);
            Controls.Add(lstDest);
            Controls.Add(lstSource);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSource;
        private ListBox lstDest;
        private Button btnAddDest;
        private Button btnAddDestAll;
        private Button btnAddSource;
        private Button btnAddSourceAll;
        private CheckBox chbDelSource;
        private Button btnForm2;
        private ProgressBar pbSource;
        private ProgressBar pbDest;
        private Button btnClearDest;
        private Button btnTask2;
    }
}
