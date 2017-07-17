using System.IO;

namespace Jpg
{
	public class BitmapData
	{
		public struct Pixel
		{
			public byte R, G, B;
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
				int rowSize = ((24 * Width + 31) / 32) * 4;

				writer.Write('B');                              // BM indicator
				writer.Write('M');
				writer.Write(14 + 40 + rowSize * Height);		// File Size: File header, DIB header, pixel data
				writer.Write(0);                                // Reserved
				writer.Write(54);                               // Pixel data starting address
				writer.Write(40);                               // DIB header size
				writer.Write(Width);                            // Image width
				writer.Write(Height);                           // Image height
				writer.Write((short)1);                         // Number of color panes (must be 1)
				writer.Write((short)24);                        // Bits per pixel
				writer.Write(0);                                // Compression method (none)
				writer.Write(0);                                // Image size (unnecessary if no compression method is given)
				writer.Write(3780);                             // Horizontal pixels per meter
				writer.Write(3780);                             // Vertical pixels per meter
				writer.Write(0);                                // Number of colors in the palette
				writer.Write(0);                                // Number of important colors (generally ignored)
				for (int h = Height - 1; h >= 0; h--)
				{
					var bArr = new byte[rowSize];
					for (int w = 0; w < Width; w++)
					{
						bArr[w * 3] = Data[w, h].B;
						bArr[w * 3 + 1] = Data[w, h].G;
						bArr[w * 3 + 2] = Data[w, h].R;
					}
					writer.Write(bArr);
				}
			}
		}
	}
}
