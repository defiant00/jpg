using System.IO;

namespace Jpg
{
	public class BitmapData
	{
		public struct Pixel
		{
			byte R, G, B;
		}

		public int Width, Height;
		public Pixel[,] Data;

		public BitmapData() { }

		public BitmapData(int width, int height)
		{
			Width = width;
			Height = height;
			Data = new Pixel[Width, Height];
		}

		public BitmapData(string fileName)
		{

		}

		public void Save(string fileName)
		{
			using (var str = new FileStream(fileName, FileMode.Create))
			using (var writer = new BinaryWriter(str))
			{
				writer.Write('B');								// BM indicator
				writer.Write('M');
				writer.Write(14 + 40 + Width * Height * 3);		// File Size: File header, DIB header, pixel data
				writer.Write(0);								// Reserved
				writer.Write(54);								// Pixel data starting address
				writer.Write(40);								// DIB header size
				writer.Write(Width);							// Image width
				writer.Write(Height);							// Image height
				writer.Write((short)1);							// Number of color panes (must be 1)
				writer.Write((short)24);						// Bits per pixel
				writer.Write(0);								// Compression method (none)
				writer.Write(0);								// Image size (unnecessary if no compression method is given)
				writer.Write(3780);								// Horizontal pixels per meter
				writer.Write(3780);								// Vertical pixels per meter
				writer.Write(0);								// Number of colors in the palette
				writer.Write(0);								// Number of important colors (generally ignored)
			}
		}
	}
}
