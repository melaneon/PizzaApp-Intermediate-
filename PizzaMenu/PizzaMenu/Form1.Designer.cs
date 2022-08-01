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
            System.Windows.Forms.TabControl tabControl1;
            this.Beverage = new System.Windows.Forms.TabPage();
            this.chkJuice = new System.Windows.Forms.CheckBox();
            this.chkCola = new System.Windows.Forms.CheckBox();
            this.Dessert = new System.Windows.Forms.TabPage();
            this.chkChocCake = new System.Windows.Forms.CheckBox();
            this.chkApplePie = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoLargeSize = new System.Windows.Forms.RadioButton();
            this.rdoMediumSize = new System.Windows.Forms.RadioButton();
            this.rdoSmallSize = new System.Windows.Forms.RadioButton();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.order = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDietary = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabControl1.SuspendLayout();
            this.Beverage.SuspendLayout();
            this.Dessert.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(this.Beverage);
            tabControl1.Controls.Add(this.Dessert);
            tabControl1.Location = new System.Drawing.Point(57, 474);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(227, 145);
            tabControl1.TabIndex = 12;
            // 
            // Beverage
            // 
            this.Beverage.Controls.Add(this.chkJuice);
            this.Beverage.Controls.Add(this.chkCola);
            this.Beverage.Location = new System.Drawing.Point(4, 29);
            this.Beverage.Name = "Beverage";
            this.Beverage.Padding = new System.Windows.Forms.Padding(3);
            this.Beverage.Size = new System.Drawing.Size(219, 112);
            this.Beverage.TabIndex = 0;
            this.Beverage.Text = "Beverage";
            this.Beverage.UseVisualStyleBackColor = true;
            // 
            // chkJuice
            // 
            this.chkJuice.AutoSize = true;
            this.chkJuice.Location = new System.Drawing.Point(22, 61);
            this.chkJuice.Name = "chkJuice";
            this.chkJuice.Size = new System.Drawing.Size(72, 24);
            this.chkJuice.TabIndex = 1;
            this.chkJuice.Text = "Juice";
            this.chkJuice.UseVisualStyleBackColor = true;
            this.chkJuice.CheckedChanged += new System.EventHandler(this.chkJuice_CheckedChanged);
            // 
            // chkCola
            // 
            this.chkCola.AutoSize = true;
            this.chkCola.Location = new System.Drawing.Point(22, 22);
            this.chkCola.Name = "chkCola";
            this.chkCola.Size = new System.Drawing.Size(67, 24);
            this.chkCola.TabIndex = 0;
            this.chkCola.Text = "Cola";
            this.chkCola.UseVisualStyleBackColor = true;
            this.chkCola.CheckedChanged += new System.EventHandler(this.chkCola_CheckedChanged);
            // 
            // Dessert
            // 
            this.Dessert.Controls.Add(this.chkChocCake);
            this.Dessert.Controls.Add(this.chkApplePie);
            this.Dessert.Location = new System.Drawing.Point(4, 29);
            this.Dessert.Name = "Dessert";
            this.Dessert.Padding = new System.Windows.Forms.Padding(3);
            this.Dessert.Size = new System.Drawing.Size(219, 112);
            this.Dessert.TabIndex = 1;
            this.Dessert.Text = "Dessert";
            this.Dessert.UseVisualStyleBackColor = true;
            // 
            // chkChocCake
            // 
            this.chkChocCake.AutoSize = true;
            this.chkChocCake.Location = new System.Drawing.Point(22, 61);
            this.chkChocCake.Name = "chkChocCake";
            this.chkChocCake.Size = new System.Drawing.Size(148, 24);
            this.chkChocCake.TabIndex = 2;
            this.chkChocCake.Text = "Chocolate Cake";
            this.chkChocCake.UseVisualStyleBackColor = true;
            this.chkChocCake.CheckedChanged += new System.EventHandler(this.chkChocCake_CheckedChanged);
            // 
            // chkApplePie
            // 
            this.chkApplePie.AutoSize = true;
            this.chkApplePie.Location = new System.Drawing.Point(22, 22);
            this.chkApplePie.Name = "chkApplePie";
            this.chkApplePie.Size = new System.Drawing.Size(102, 24);
            this.chkApplePie.TabIndex = 1;
            this.chkApplePie.Text = "Apple Pie";
            this.chkApplePie.UseVisualStyleBackColor = true;
            this.chkApplePie.CheckedChanged += new System.EventHandler(this.chkApplePie_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoLargeSize);
            this.groupBox1.Controls.Add(this.rdoMediumSize);
            this.groupBox1.Controls.Add(this.rdoSmallSize);
            this.groupBox1.Location = new System.Drawing.Point(45, 110);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(211, 213);
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
            this.rdoLargeSize.Size = new System.Drawing.Size(132, 24);
            this.rdoLargeSize.TabIndex = 2;
            this.rdoLargeSize.Text = "large ($17.50)";
            this.rdoLargeSize.UseVisualStyleBackColor = true;
            this.rdoLargeSize.Click += new System.EventHandler(this.PizzaSize_CheckedChanged);
            // 
            // rdoMediumSize
            // 
            this.rdoMediumSize.AutoSize = true;
            this.rdoMediumSize.Location = new System.Drawing.Point(38, 86);
            this.rdoMediumSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoMediumSize.Name = "rdoMediumSize";
            this.rdoMediumSize.Size = new System.Drawing.Size(153, 24);
            this.rdoMediumSize.TabIndex = 1;
            this.rdoMediumSize.Text = "medium ($12.50)";
            this.rdoMediumSize.UseVisualStyleBackColor = true;
            this.rdoMediumSize.Click += new System.EventHandler(this.PizzaSize_CheckedChanged);
            // 
            // rdoSmallSize
            // 
            this.rdoSmallSize.AutoSize = true;
            this.rdoSmallSize.Location = new System.Drawing.Point(38, 49);
            this.rdoSmallSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoSmallSize.Name = "rdoSmallSize";
            this.rdoSmallSize.Size = new System.Drawing.Size(133, 24);
            this.rdoSmallSize.TabIndex = 0;
            this.rdoSmallSize.Text = "small ($10.50)";
            this.rdoSmallSize.UseVisualStyleBackColor = true;
            this.rdoSmallSize.Click += new System.EventHandler(this.PizzaSize_CheckedChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtTotal.Location = new System.Drawing.Point(540, 593);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(134, 26);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 596);
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
            this.groupBox2.Location = new System.Drawing.Point(473, 110);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(212, 213);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pizza Toppings";
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(155, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Mushrooms(+2$)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Calzone",
            "Cheese",
            "Deep Dish",
            "Hawaiian",
            "Lahma Bi Ajeen",
            "Margherita",
            "Marinara",
            "Neapolitan",
            "Stromboli",
            "The M&L Special"});
            this.listBox1.Location = new System.Drawing.Point(283, 119);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(169, 204);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // order
            // 
            this.order.FormattingEnabled = true;
            this.order.ItemHeight = 20;
            this.order.Location = new System.Drawing.Point(345, 372);
            this.order.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.order.Name = "order";
            this.order.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.order.Size = new System.Drawing.Size(329, 164);
            this.order.Sorted = true;
            this.order.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "If you have a dietary restriction:";
            // 
            // cboDietary
            // 
            this.cboDietary.FormattingEnabled = true;
            this.cboDietary.Items.AddRange(new object[] {
            "N/A",
            "100 mile",
            "Gluten free",
            "Kosher",
            "Lactose",
            "Non-GMO",
            "Paleo",
            "Vegan",
            "Vegetarian"});
            this.cboDietary.Location = new System.Drawing.Point(61, 393);
            this.cboDietary.Name = "cboDietary";
            this.cboDietary.Size = new System.Drawing.Size(223, 28);
            this.cboDietary.TabIndex = 8;
            this.cboDietary.SelectedIndexChanged += new System.EventHandler(this.cboDietary_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 72);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(719, 36);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pizzaToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(74, 30);
            this.toolStripMenuItem1.Text = "Order";
            // 
            // pizzaToolStripMenuItem
            // 
            this.pizzaToolStripMenuItem.Name = "pizzaToolStripMenuItem";
            this.pizzaToolStripMenuItem.Size = new System.Drawing.Size(156, 34);
            this.pizzaToolStripMenuItem.Text = "Pizza";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(156, 34);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(78, 30);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Location = new System.Drawing.Point(0, 36);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(719, 36);
            this.menuStrip2.TabIndex = 10;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip3
            // 
            this.menuStrip3.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(719, 36);
            this.menuStrip3.TabIndex = 11;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 669);
            this.Controls.Add(tabControl1);
            this.Controls.Add(this.cboDietary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.order);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "M&L Pizza Palace";
            this.Load += new System.EventHandler(this.Form1_Load);
            tabControl1.ResumeLayout(false);
            this.Beverage.ResumeLayout(false);
            this.Beverage.PerformLayout();
            this.Dessert.ResumeLayout(false);
            this.Dessert.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox order;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDietary;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.TabPage Beverage;
        private System.Windows.Forms.TabPage Dessert;
        private System.Windows.Forms.CheckBox chkJuice;
        private System.Windows.Forms.CheckBox chkCola;
        private System.Windows.Forms.CheckBox chkChocCake;
        private System.Windows.Forms.CheckBox chkApplePie;
    }
}

