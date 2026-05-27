namespace SDT621_SA_SectionC
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCode = new TextBox();
            txtMake = new TextBox();
            txtQuantity = new TextBox();
            lblOutput = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnFind = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 112);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Mobile Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 147);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Make";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(219, 181);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Quantity";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(316, 109);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(152, 23);
            txtCode.TabIndex = 3;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(316, 144);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(152, 23);
            txtMake.TabIndex = 4;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(316, 178);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(152, 23);
            txtQuantity.TabIndex = 5;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(194, 50);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(38, 15);
            lblOutput.TabIndex = 6;
            lblOutput.Text = "label4";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(197, 233);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(316, 233);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(429, 233);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(75, 23);
            btnFind.TabIndex = 9;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFind);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lblOutput);
            Controls.Add(txtQuantity);
            Controls.Add(txtMake);
            Controls.Add(txtCode);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCode;
        private TextBox txtMake;
        private TextBox txtQuantity;
        private Label lblOutput;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnFind;
    }
}
