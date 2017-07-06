using System;
using System.Windows.Forms;

namespace Jpg
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void buttonDecode_Click(object sender, EventArgs e)
		{
			//var open = new OpenFileDialog { Filter = "JPG Image|*.jpg;*.jpeg" };
			//if (open.ShowDialog() == DialogResult.OK)
			//{
				var save = new SaveFileDialog { Filter = "Bitmap Image|*.bmp" };
				if (save.ShowDialog() == DialogResult.OK)
				{
					var bmp = new BitmapData(2, 2);
					bmp.Save(save.FileName);
				}
			//}
		}

		private void buttonEncode_Click(object sender, EventArgs e)
		{
			var open = new OpenFileDialog { Filter = "Bitmap Image|*.bmp" };
			if (open.ShowDialog() == DialogResult.OK)
			{
				var save = new SaveFileDialog { Filter = "JPG Image|*.jpg" };
				if (save.ShowDialog() == DialogResult.OK)
				{

				}
			}
		}
	}
}
