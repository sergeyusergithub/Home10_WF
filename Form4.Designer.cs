namespace Home10_WF
{
    partial class Form4
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
            txtBoxEdit = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtBoxEdit
            // 
            txtBoxEdit.Location = new Point(27, 26);
            txtBoxEdit.Multiline = true;
            txtBoxEdit.Name = "txtBoxEdit";
            txtBoxEdit.Size = new Size(591, 396);
            txtBoxEdit.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(637, 47);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(151, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(637, 116);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(151, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Отменить";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtBoxEdit);
            Name = "Form4";
            Text = "Редактировать";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxEdit;
        private Button btnSave;
        private Button btnCancel;
    }
}