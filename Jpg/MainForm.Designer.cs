namespace Jpg
{
	partial class MainForm
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
			this.buttonDecode = new System.Windows.Forms.Button();
			this.buttonEncode = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonDecode
			// 
			this.buttonDecode.Location = new System.Drawing.Point(8, 8);
			this.buttonDecode.Name = "buttonDecode";
			this.buttonDecode.Size = new System.Drawing.Size(80, 32);
			this.buttonDecode.TabIndex = 0;
			this.buttonDecode.Text = "Decode";
			this.buttonDecode.UseVisualStyleBackColor = true;
			this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
			// 
			// buttonEncode
			// 
			this.buttonEncode.Location = new System.Drawing.Point(104, 8);
			this.buttonEncode.Name = "buttonEncode";
			this.buttonEncode.Size = new System.Drawing.Size(80, 32);
			this.buttonEncode.TabIndex = 1;
			this.buttonEncode.Text = "Encode";
			this.buttonEncode.UseVisualStyleBackColor = true;
			this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(192, 50);
			this.Controls.Add(this.buttonEncode);
			this.Controls.Add(this.buttonDecode);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "JPG Test";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonDecode;
		private System.Windows.Forms.Button buttonEncode;
	}
}

