namespace Home10_WF
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txbMain = new TextBox();
            btnOpenFile = new Button();
            btnEdit = new Button();
            openFileDialog = new OpenFileDialog();
            SuspendLayout();
            // 
            // txbMain
            // 
            txbMain.Location = new Point(24, 33);
            txbMain.Multiline = true;
            txbMain.Name = "txbMain";
            txbMain.ReadOnly = true;
            txbMain.ScrollBars = ScrollBars.Vertical;
            txbMain.Size = new Size(579, 405);
            txbMain.TabIndex = 0;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(628, 33);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(160, 28);
            btnOpenFile.TabIndex = 1;
            btnOpenFile.Text = "Загрузить файл";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // btnEdit
            // 
            btnEdit.Enabled = false;
            btnEdit.Location = new Point(628, 91);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(160, 30);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "Текстовый файл (*.txt)|*.txt";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEdit);
            Controls.Add(btnOpenFile);
            Controls.Add(txbMain);
            Name = "Form3";
            Text = "Задание2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbMain;
        private Button btnOpenFile;
        private Button btnEdit;
        private OpenFileDialog openFileDialog;
    }
}