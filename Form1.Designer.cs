namespace Mobile_Stock_App
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
            lblOutput = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCode = new TextBox();
            txtMake = new TextBox();
            txtQuantify = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnFind = new Button();
            SuspendLayout();
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(142, 29);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(0, 20);
            lblOutput.TabIndex = 0;
            lblOutput.Click += lblOutput_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 99);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 1;
            label2.Text = "Mobile Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 144);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 2;
            label3.Text = "Make";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(117, 190);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "Quantity";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(273, 92);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(125, 27);
            txtCode.TabIndex = 4;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(273, 137);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(125, 27);
            txtMake.TabIndex = 5;
            // 
            // txtQuantify
            // 
            txtQuantify.Location = new Point(273, 187);
            txtQuantify.Name = "txtQuantify";
            txtQuantify.Size = new Size(125, 27);
            txtQuantify.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(98, 243);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(208, 243);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(322, 243);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 29);
            btnFind.TabIndex = 9;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFind);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtQuantify);
            Controls.Add(txtMake);
            Controls.Add(txtCode);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblOutput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOutput;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCode;
        private TextBox txtMake;
        private TextBox txtQuantify;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnFind;
    }
}
