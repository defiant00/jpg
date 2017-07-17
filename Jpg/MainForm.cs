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
				var bmp = new BitmapData(7, 7);
				bmp.Data[0, 0] = new BitmapData.Pixel { R = 255, G = 0, B = 0 };
				bmp.Data[0, 6] = new BitmapData.Pixel { R = 128, G = 0, B = 128 };
				bmp.Data[6, 0] = new BitmapData.Pixel { R = 0, G = 64, B = 0 };
				bmp.Data[6, 6] = new BitmapData.Pixel { R = 0, G = 0, B = 32 };
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
