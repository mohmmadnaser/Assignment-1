namespace WindowsFormsApp111
{
    partial class Form1
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
            this.txtNumberOfControls = new System.Windows.Forms.TextBox();
            this.lblNumberOFControls = new System.Windows.Forms.Label();
            this.btnCreateControls = new System.Windows.Forms.Button();
            this.pnlDynamicControls = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbltabe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumberOfControls
            // 
            this.txtNumberOfControls.Location = new System.Drawing.Point(266, 64);
            this.txtNumberOfControls.Name = "txtNumberOfControls";
            this.txtNumberOfControls.Size = new System.Drawing.Size(221, 22);
            this.txtNumberOfControls.TabIndex = 0;
            // 
            // lblNumberOFControls
            // 
            this.lblNumberOFControls.AutoSize = true;
            this.lblNumberOFControls.Location = new System.Drawing.Point(139, 64);
            this.lblNumberOFControls.Name = "lblNumberOFControls";
            this.lblNumberOFControls.Size = new System.Drawing.Size(121, 16);
            this.lblNumberOFControls.TabIndex = 1;
            this.lblNumberOFControls.Text = "Number of Controls";
            // 
            // btnCreateControls
            // 
            this.btnCreateControls.Location = new System.Drawing.Point(266, 101);
            this.btnCreateControls.Name = "btnCreateControls";
            this.btnCreateControls.Size = new System.Drawing.Size(221, 23);
            this.btnCreateControls.TabIndex = 2;
            this.btnCreateControls.Text = "Create Controls";
            this.btnCreateControls.UseVisualStyleBackColor = true;
            this.btnCreateControls.Click += new System.EventHandler(this.btnCreateControls_Click);
            // 
            // pnlDynamicControls
            // 
            this.pnlDynamicControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDynamicControls.Location = new System.Drawing.Point(114, 153);
            this.pnlDynamicControls.Name = "pnlDynamicControls";
            this.pnlDynamicControls.Size = new System.Drawing.Size(536, 474);
            this.pnlDynamicControls.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Button",
            "Lable",
            "Texbox"});
            this.comboBox1.Location = new System.Drawing.Point(266, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // lbltabe
            // 
            this.lbltabe.AutoSize = true;
            this.lbltabe.Location = new System.Drawing.Point(164, 36);
            this.lbltabe.Name = "lbltabe";
            this.lbltabe.Size = new System.Drawing.Size(84, 16);
            this.lbltabe.TabIndex = 5;
            this.lbltabe.Text = "Control Tybe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 715);
            this.Controls.Add(this.lbltabe);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pnlDynamicControls);
            this.Controls.Add(this.btnCreateControls);
            this.Controls.Add(this.lblNumberOFControls);
            this.Controls.Add(this.txtNumberOfControls);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumberOfControls;
        private System.Windows.Forms.Label lblNumberOFControls;
        private System.Windows.Forms.Button btnCreateControls;
        private System.Windows.Forms.Panel pnlDynamicControls;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbltabe;
    }
}

