namespace IceCream.Forms
{
	partial class AddIceCreamForm
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
			this.iceCreamList = new System.Windows.Forms.ListView();
			this.button1 = new System.Windows.Forms.Button();
			this.nameBox = new System.Windows.Forms.TextBox();
			this.nameLabel = new System.Windows.Forms.Label();
			this.costBox = new System.Windows.Forms.TextBox();
			this.costLabel = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.flavorLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// iceCreamList
			// 
			this.iceCreamList.Location = new System.Drawing.Point(260, 12);
			this.iceCreamList.Name = "iceCreamList";
			this.iceCreamList.Size = new System.Drawing.Size(317, 221);
			this.iceCreamList.TabIndex = 0;
			this.iceCreamList.UseCompatibleStateImageBehavior = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 227);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// nameBox
			// 
			this.nameBox.Location = new System.Drawing.Point(59, 12);
			this.nameBox.Name = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(100, 20);
			this.nameBox.TabIndex = 2;
			this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(18, 15);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(35, 13);
			this.nameLabel.TabIndex = 3;
			this.nameLabel.Text = "Name";
			this.nameLabel.Click += new System.EventHandler(this.label1_Click);
			// 
			// costBox
			// 
			this.costBox.Location = new System.Drawing.Point(59, 39);
			this.costBox.Name = "costBox";
			this.costBox.Size = new System.Drawing.Size(100, 20);
			this.costBox.TabIndex = 4;
			// 
			// costLabel
			// 
			this.costLabel.AutoSize = true;
			this.costLabel.Location = new System.Drawing.Point(18, 39);
			this.costLabel.Name = "costLabel";
			this.costLabel.Size = new System.Drawing.Size(28, 13);
			this.costLabel.TabIndex = 5;
			this.costLabel.Text = "Cost";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(59, 66);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 6;
			// 
			// flavorLabel
			// 
			this.flavorLabel.AutoSize = true;
			this.flavorLabel.Location = new System.Drawing.Point(18, 66);
			this.flavorLabel.Name = "flavorLabel";
			this.flavorLabel.Size = new System.Drawing.Size(36, 13);
			this.flavorLabel.TabIndex = 7;
			this.flavorLabel.Text = "Flavor";
			// 
			// AddIceCreamForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(589, 262);
			this.Controls.Add(this.flavorLabel);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.costLabel);
			this.Controls.Add(this.costBox);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.nameBox);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.iceCreamList);
			this.Name = "AddIceCreamForm";
			this.Text = "Add Ice Cream";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView iceCreamList;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox nameBox;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.TextBox costBox;
		private System.Windows.Forms.Label costLabel;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label flavorLabel;
	}
}

