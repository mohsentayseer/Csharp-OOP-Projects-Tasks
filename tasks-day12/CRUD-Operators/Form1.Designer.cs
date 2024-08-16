namespace CRUD_Operators
{
    partial class frmCRUDOperators
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
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.BackgroundImageLayout = ImageLayout.None;
            btnDelete.Font = new Font("Segoe UI", 10F);
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(795, 811);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(188, 58);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DodgerBlue;
            btnUpdate.Font = new Font("Segoe UI", 10F);
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(293, 811);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(188, 58);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.LimeGreen;
            btnInsert.Font = new Font("Segoe UI", 10F);
            btnInsert.ForeColor = SystemColors.ControlLightLight;
            btnInsert.Location = new Point(31, 811);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(188, 58);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(167, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(418, 49);
            comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(31, 75);
            label1.Name = "label1";
            label1.Size = new Size(124, 53);
            label1.TabIndex = 6;
            label1.Text = "Users";
            // 
            // frmCRUDOperators
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1019, 964);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(btnInsert);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Cursor = Cursors.Hand;
            Name = "frmCRUDOperators";
            Text = "CURD Operators Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private ComboBox comboBox1;
        private Label label1;
    }
}
