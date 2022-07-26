namespace Problem10
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoLargeSize = new System.Windows.Forms.RadioButton();
            this.rdoMediumSize = new System.Windows.Forms.RadioButton();
            this.rdoSmallSize = new System.Windows.Forms.RadioButton();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoLargeSize);
            this.groupBox1.Controls.Add(this.rdoMediumSize);
            this.groupBox1.Controls.Add(this.rdoSmallSize);
            this.groupBox1.Location = new System.Drawing.Point(118, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(206, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pizza size";
            // 
            // rdoLargeSize
            // 
            this.rdoLargeSize.AutoSize = true;
            this.rdoLargeSize.Location = new System.Drawing.Point(38, 123);
            this.rdoLargeSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoLargeSize.Name = "rdoLargeSize";
            this.rdoLargeSize.Size = new System.Drawing.Size(110, 24);
            this.rdoLargeSize.TabIndex = 2;
            this.rdoLargeSize.Text = "large ($20)";
            this.rdoLargeSize.UseVisualStyleBackColor = true;
            this.rdoLargeSize.CheckedChanged += new System.EventHandler(this.PizzaSize_CheckedChanged);
            // 
            // rdoMediumSize
            // 
            this.rdoMediumSize.AutoSize = true;
            this.rdoMediumSize.Location = new System.Drawing.Point(38, 86);
            this.rdoMediumSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoMediumSize.Name = "rdoMediumSize";
            this.rdoMediumSize.Size = new System.Drawing.Size(131, 24);
            this.rdoMediumSize.TabIndex = 1;
            this.rdoMediumSize.Text = "medium ($15)";
            this.rdoMediumSize.UseVisualStyleBackColor = true;
            this.rdoMediumSize.CheckedChanged += new System.EventHandler(this.PizzaSize_CheckedChanged);
            // 
            // rdoSmallSize
            // 
            this.rdoSmallSize.AutoSize = true;
            this.rdoSmallSize.Location = new System.Drawing.Point(38, 49);
            this.rdoSmallSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoSmallSize.Name = "rdoSmallSize";
            this.rdoSmallSize.Size = new System.Drawing.Size(111, 24);
            this.rdoSmallSize.TabIndex = 0;
            this.rdoSmallSize.Text = "small ($10)";
            this.rdoSmallSize.UseVisualStyleBackColor = true;
            this.rdoSmallSize.CheckedChanged += new System.EventHandler(this.PizzaSize_CheckedChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(176, 590);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(148, 26);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 595);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(118, 331);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(206, 178);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pizza Toppings";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(155, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Mushrooms(+2$)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(24, 87);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(157, 24);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Black Olives(+3$)";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(24, 126);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(144, 24);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Pepperoni(+5$)";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 693);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "M&L Pizza Palace";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoLargeSize;
        private System.Windows.Forms.RadioButton rdoMediumSize;
        private System.Windows.Forms.RadioButton rdoSmallSize;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

