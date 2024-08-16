namespace CRUD_Operators
{
    partial class TrySelect
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
            gridAuthors = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridAuthors).BeginInit();
            SuspendLayout();
            // 
            // gridAuthors
            // 
            gridAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridAuthors.Location = new Point(12, 12);
            gridAuthors.Name = "gridAuthors";
            gridAuthors.RowHeadersWidth = 102;
            gridAuthors.Size = new Size(1227, 959);
            gridAuthors.TabIndex = 0;
            // 
            // TrySelect
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 983);
            Controls.Add(gridAuthors);
            Name = "TrySelect";
            Text = "TrySelect";
            ((System.ComponentModel.ISupportInitialize)gridAuthors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridAuthors;
    }
}