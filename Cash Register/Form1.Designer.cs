namespace Cash_Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subTotal = new System.Windows.Forms.Label();
            this.Tax = new System.Windows.Forms.Label();
            this.TotalCost = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tendered1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.changeBox = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.newOrder = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iphone X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AirPods";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Charging Block";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(75, 57);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(214, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(47, 135);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(239, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // subTotal
            // 
            this.subTotal.AutoSize = true;
            this.subTotal.Location = new System.Drawing.Point(111, 161);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(53, 13);
            this.subTotal.TabIndex = 7;
            this.subTotal.Text = "SubTotal:";
            // 
            // Tax
            // 
            this.Tax.AutoSize = true;
            this.Tax.Location = new System.Drawing.Point(111, 187);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(28, 13);
            this.Tax.TabIndex = 8;
            this.Tax.Text = "Tax:";
            // 
            // TotalCost
            // 
            this.TotalCost.AutoSize = true;
            this.TotalCost.Location = new System.Drawing.Point(111, 209);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(34, 13);
            this.TotalCost.TabIndex = 9;
            this.TotalCost.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Charge Cable";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(72, 81);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(214, 20);
            this.textBox4.TabIndex = 11;
            // 
            // tendered1
            // 
            this.tendered1.AutoSize = true;
            this.tendered1.Location = new System.Drawing.Point(111, 235);
            this.tendered1.Name = "tendered1";
            this.tendered1.Size = new System.Drawing.Size(53, 13);
            this.tendered1.TabIndex = 12;
            this.tendered1.Text = "Tendered";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(201, 232);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(130, 20);
            this.textBox5.TabIndex = 13;
            // 
            // changeBox
            // 
            this.changeBox.AutoSize = true;
            this.changeBox.Location = new System.Drawing.Point(114, 290);
            this.changeBox.Name = "changeBox";
            this.changeBox.Size = new System.Drawing.Size(44, 13);
            this.changeBox.TabIndex = 14;
            this.changeBox.Text = "Change";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(144, 258);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(161, 23);
            this.changeButton.TabIndex = 15;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(117, 323);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(214, 23);
            this.print.TabIndex = 16;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.Print_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(566, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 81);
            this.label6.MinimumSize = new System.Drawing.Size(380, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(380, 290);
            this.label6.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(352, 4);
            this.label7.MinimumSize = new System.Drawing.Size(450, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(450, 40);
            this.label7.TabIndex = 19;
            this.label7.Text = "Apple Store";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 20;
            // 
            // newOrder
            // 
            this.newOrder.Location = new System.Drawing.Point(519, 323);
            this.newOrder.Name = "newOrder";
            this.newOrder.Size = new System.Drawing.Size(141, 23);
            this.newOrder.TabIndex = 21;
            this.newOrder.Text = "New Order";
            this.newOrder.UseVisualStyleBackColor = true;
            this.newOrder.Click += new System.EventHandler(this.NewOrder_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(293, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "$999";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(290, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "$220";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(293, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "$59";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(296, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "$19";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.newOrder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.print);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.changeBox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.tendered1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TotalCost);
            this.Controls.Add(this.Tax);
            this.Controls.Add(this.subTotal);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subTotal;
        private System.Windows.Forms.Label Tax;
        private System.Windows.Forms.Label TotalCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label tendered1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label changeBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button newOrder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

