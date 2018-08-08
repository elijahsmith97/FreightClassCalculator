namespace FreightClass
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.textWidth = new System.Windows.Forms.TextBox();
            this.textDepth = new System.Windows.Forms.TextBox();
            this.textWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textFreightClass = new System.Windows.Forms.TextBox();
            this.historyLog = new System.Windows.Forms.ListBox();
            this.textDensity = new System.Windows.Forms.TextBox();
            this.Density = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.textTotalDensity = new System.Windows.Forms.TextBox();
            this.textFreightTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(135, 310);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.buttonCalc);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(386, 259);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Add";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnAdd);
            // 
            // textHeight
            // 
            this.textHeight.Location = new System.Drawing.Point(110, 19);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(100, 20);
            this.textHeight.TabIndex = 2;
            // 
            // textWidth
            // 
            this.textWidth.Location = new System.Drawing.Point(110, 54);
            this.textWidth.Name = "textWidth";
            this.textWidth.Size = new System.Drawing.Size(100, 20);
            this.textWidth.TabIndex = 3;
            // 
            // textDepth
            // 
            this.textDepth.Location = new System.Drawing.Point(110, 90);
            this.textDepth.Name = "textDepth";
            this.textDepth.Size = new System.Drawing.Size(100, 20);
            this.textDepth.TabIndex = 4;
            // 
            // textWeight
            // 
            this.textWeight.Location = new System.Drawing.Point(110, 123);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(100, 20);
            this.textWeight.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Depth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Weight:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Freight Class:";
            // 
            // textFreightClass
            // 
            this.textFreightClass.Location = new System.Drawing.Point(110, 235);
            this.textFreightClass.Name = "textFreightClass";
            this.textFreightClass.ReadOnly = true;
            this.textFreightClass.Size = new System.Drawing.Size(100, 20);
            this.textFreightClass.TabIndex = 11;
            // 
            // historyLog
            // 
            this.historyLog.FormattingEnabled = true;
            this.historyLog.Location = new System.Drawing.Point(252, 19);
            this.historyLog.Name = "historyLog";
            this.historyLog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.historyLog.Size = new System.Drawing.Size(209, 238);
            this.historyLog.TabIndex = 12;
            // 
            // textDensity
            // 
            this.textDensity.Location = new System.Drawing.Point(110, 202);
            this.textDensity.Name = "textDensity";
            this.textDensity.ReadOnly = true;
            this.textDensity.Size = new System.Drawing.Size(100, 20);
            this.textDensity.TabIndex = 13;
            // 
            // Density
            // 
            this.Density.AutoSize = true;
            this.Density.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Density.Location = new System.Drawing.Point(35, 202);
            this.Density.Name = "Density";
            this.Density.Size = new System.Drawing.Size(53, 13);
            this.Density.TabIndex = 14;
            this.Density.Text = "Density:";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(259, 288);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(86, 13);
            this.total.TabIndex = 15;
            this.total.Text = "Density Total:";
            // 
            // textTotalDensity
            // 
            this.textTotalDensity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textTotalDensity.Location = new System.Drawing.Point(368, 288);
            this.textTotalDensity.Name = "textTotalDensity";
            this.textTotalDensity.ReadOnly = true;
            this.textTotalDensity.Size = new System.Drawing.Size(93, 20);
            this.textTotalDensity.TabIndex = 16;
            // 
            // textFreightTotal
            // 
            this.textFreightTotal.Location = new System.Drawing.Point(368, 315);
            this.textFreightTotal.Name = "textFreightTotal";
            this.textFreightTotal.ReadOnly = true;
            this.textFreightTotal.Size = new System.Drawing.Size(93, 20);
            this.textFreightTotal.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(228, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Frieght Class Total:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(7, 310);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(477, 345);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textFreightTotal);
            this.Controls.Add(this.textTotalDensity);
            this.Controls.Add(this.total);
            this.Controls.Add(this.Density);
            this.Controls.Add(this.textDensity);
            this.Controls.Add(this.historyLog);
            this.Controls.Add(this.textFreightClass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textWeight);
            this.Controls.Add(this.textDepth);
            this.Controls.Add(this.textWidth);
            this.Controls.Add(this.textHeight);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Freight Class Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.TextBox textWidth;
        private System.Windows.Forms.TextBox textDepth;
        private System.Windows.Forms.TextBox textWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textFreightClass;
        private System.Windows.Forms.ListBox historyLog;
        private System.Windows.Forms.TextBox textDensity;
        private System.Windows.Forms.Label Density;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.TextBox textTotalDensity;
        private System.Windows.Forms.TextBox textFreightTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
    }
}

