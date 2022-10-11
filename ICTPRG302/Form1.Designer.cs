namespace Percentage_Calculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.percentageRes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.allocatedCases = new System.Windows.Forms.NumericUpDown();
            this.closedCases = new System.Windows.Forms.NumericUpDown();
            this.userbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.allocatedCases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closedCases)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate % Completed";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // percentageRes
            // 
            this.percentageRes.BackColor = System.Drawing.SystemColors.Info;
            this.percentageRes.Location = new System.Drawing.Point(52, 243);
            this.percentageRes.Name = "percentageRes";
            this.percentageRes.ReadOnly = true;
            this.percentageRes.Size = new System.Drawing.Size(293, 27);
            this.percentageRes.TabIndex = 3;
            this.percentageRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Allocated Cases";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Closed Cases";
            // 
            // allocatedCases
            // 
            this.allocatedCases.Location = new System.Drawing.Point(195, 96);
            this.allocatedCases.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.allocatedCases.Name = "allocatedCases";
            this.allocatedCases.Size = new System.Drawing.Size(150, 27);
            this.allocatedCases.TabIndex = 6;
            // 
            // closedCases
            // 
            this.closedCases.Location = new System.Drawing.Point(195, 129);
            this.closedCases.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.closedCases.Name = "closedCases";
            this.closedCases.Size = new System.Drawing.Size(150, 27);
            this.closedCases.TabIndex = 7;
            // 
            // userbox
            // 
            this.userbox.BackColor = System.Drawing.SystemColors.Window;
            this.userbox.Location = new System.Drawing.Point(52, 63);
            this.userbox.Name = "userbox";
            this.userbox.Size = new System.Drawing.Size(293, 27);
            this.userbox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Username";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(388, 344);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userbox);
            this.Controls.Add(this.closedCases);
            this.Controls.Add(this.allocatedCases);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.percentageRes);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Percentage Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.allocatedCases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closedCases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private TextBox percentageRes;
        private Label label1;
        private Label label2;
        private NumericUpDown allocatedCases;
        private NumericUpDown closedCases;
        private TextBox userbox;
        private Label label3;
    }
}