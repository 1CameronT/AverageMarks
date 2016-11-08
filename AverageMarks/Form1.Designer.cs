namespace AverageMarks
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
            this.txtDisplay1 = new System.Windows.Forms.TextBox();
            this.txtDisplay2 = new System.Windows.Forms.TextBox();
            this.txtDisplay3 = new System.Windows.Forms.TextBox();
            this.txtDisplay4 = new System.Windows.Forms.TextBox();
            this.txtDisplay5 = new System.Windows.Forms.TextBox();
            this.lblDisplay1 = new System.Windows.Forms.Label();
            this.lblDisplay2 = new System.Windows.Forms.Label();
            this.lblDisplay3 = new System.Windows.Forms.Label();
            this.lblDisplay4 = new System.Windows.Forms.Label();
            this.lblDisplay5 = new System.Windows.Forms.Label();
            this.btnDisplay1 = new System.Windows.Forms.Button();
            this.lblDisplay6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDisplay1
            // 
            this.txtDisplay1.Location = new System.Drawing.Point(152, 19);
            this.txtDisplay1.Name = "txtDisplay1";
            this.txtDisplay1.Size = new System.Drawing.Size(100, 20);
            this.txtDisplay1.TabIndex = 0;
            this.txtDisplay1.TextChanged += new System.EventHandler(this.txtDisplay1_TextChanged);
            // 
            // txtDisplay2
            // 
            this.txtDisplay2.Location = new System.Drawing.Point(152, 45);
            this.txtDisplay2.Name = "txtDisplay2";
            this.txtDisplay2.Size = new System.Drawing.Size(100, 20);
            this.txtDisplay2.TabIndex = 1;
            // 
            // txtDisplay3
            // 
            this.txtDisplay3.Location = new System.Drawing.Point(152, 71);
            this.txtDisplay3.Name = "txtDisplay3";
            this.txtDisplay3.Size = new System.Drawing.Size(100, 20);
            this.txtDisplay3.TabIndex = 2;
            // 
            // txtDisplay4
            // 
            this.txtDisplay4.Location = new System.Drawing.Point(152, 97);
            this.txtDisplay4.Name = "txtDisplay4";
            this.txtDisplay4.Size = new System.Drawing.Size(100, 20);
            this.txtDisplay4.TabIndex = 3;
            // 
            // txtDisplay5
            // 
            this.txtDisplay5.Location = new System.Drawing.Point(152, 123);
            this.txtDisplay5.Name = "txtDisplay5";
            this.txtDisplay5.Size = new System.Drawing.Size(100, 20);
            this.txtDisplay5.TabIndex = 4;
            // 
            // lblDisplay1
            // 
            this.lblDisplay1.Location = new System.Drawing.Point(22, 19);
            this.lblDisplay1.Name = "lblDisplay1";
            this.lblDisplay1.Size = new System.Drawing.Size(100, 23);
            this.lblDisplay1.TabIndex = 5;
            this.lblDisplay1.Text = "First Mark";
            this.lblDisplay1.Click += new System.EventHandler(this.lblDisplay1_Click);
            // 
            // lblDisplay2
            // 
            this.lblDisplay2.Location = new System.Drawing.Point(22, 47);
            this.lblDisplay2.Name = "lblDisplay2";
            this.lblDisplay2.Size = new System.Drawing.Size(100, 13);
            this.lblDisplay2.TabIndex = 6;
            this.lblDisplay2.Text = "Second Mark";
            this.lblDisplay2.Click += new System.EventHandler(this.lblDisplay2_Click);
            // 
            // lblDisplay3
            // 
            this.lblDisplay3.Location = new System.Drawing.Point(22, 73);
            this.lblDisplay3.Name = "lblDisplay3";
            this.lblDisplay3.Size = new System.Drawing.Size(100, 13);
            this.lblDisplay3.TabIndex = 7;
            this.lblDisplay3.Text = "Third Mark";
            this.lblDisplay3.Click += new System.EventHandler(this.lblDisplay3_Click);
            // 
            // lblDisplay4
            // 
            this.lblDisplay4.Location = new System.Drawing.Point(22, 99);
            this.lblDisplay4.Name = "lblDisplay4";
            this.lblDisplay4.Size = new System.Drawing.Size(100, 13);
            this.lblDisplay4.TabIndex = 8;
            this.lblDisplay4.Text = "Fourth Mark";
            this.lblDisplay4.Click += new System.EventHandler(this.lblDisplay4_Click);
            // 
            // lblDisplay5
            // 
            this.lblDisplay5.Location = new System.Drawing.Point(22, 125);
            this.lblDisplay5.Name = "lblDisplay5";
            this.lblDisplay5.Size = new System.Drawing.Size(100, 17);
            this.lblDisplay5.TabIndex = 9;
            this.lblDisplay5.Text = "Fifth Mark";
            this.lblDisplay5.Click += new System.EventHandler(this.lblDisplay5_Click);
            // 
            // btnDisplay1
            // 
            this.btnDisplay1.Location = new System.Drawing.Point(12, 226);
            this.btnDisplay1.Name = "btnDisplay1";
            this.btnDisplay1.Size = new System.Drawing.Size(110, 23);
            this.btnDisplay1.TabIndex = 10;
            this.btnDisplay1.Text = "Calculate Average";
            this.btnDisplay1.UseVisualStyleBackColor = true;
            this.btnDisplay1.Click += new System.EventHandler(this.btnDisplay1_Click);
            // 
            // lblDisplay6
            // 
            this.lblDisplay6.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay6.Location = new System.Drawing.Point(152, 159);
            this.lblDisplay6.Name = "lblDisplay6";
            this.lblDisplay6.Size = new System.Drawing.Size(195, 160);
            this.lblDisplay6.TabIndex = 11;
            this.lblDisplay6.Click += new System.EventHandler(this.lblDisplay6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 340);
            this.Controls.Add(this.lblDisplay6);
            this.Controls.Add(this.btnDisplay1);
            this.Controls.Add(this.lblDisplay5);
            this.Controls.Add(this.lblDisplay4);
            this.Controls.Add(this.lblDisplay3);
            this.Controls.Add(this.lblDisplay2);
            this.Controls.Add(this.lblDisplay1);
            this.Controls.Add(this.txtDisplay5);
            this.Controls.Add(this.txtDisplay4);
            this.Controls.Add(this.txtDisplay3);
            this.Controls.Add(this.txtDisplay2);
            this.Controls.Add(this.txtDisplay1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay1;
        private System.Windows.Forms.TextBox txtDisplay2;
        private System.Windows.Forms.TextBox txtDisplay3;
        private System.Windows.Forms.TextBox txtDisplay4;
        private System.Windows.Forms.TextBox txtDisplay5;
        private System.Windows.Forms.Label lblDisplay1;
        private System.Windows.Forms.Label lblDisplay2;
        private System.Windows.Forms.Label lblDisplay3;
        private System.Windows.Forms.Label lblDisplay4;
        private System.Windows.Forms.Label lblDisplay5;
        private System.Windows.Forms.Button btnDisplay1;
        private System.Windows.Forms.Label lblDisplay6;
    }
}

