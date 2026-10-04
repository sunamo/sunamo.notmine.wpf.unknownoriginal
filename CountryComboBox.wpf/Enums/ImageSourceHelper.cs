public class ImageSourceHelper
{
	public static ImageSource ImageSourceFromBitmap2(Bitmap bmp)
	{
		MemoryStream ms = new MemoryStream();
		((System.Drawing.Bitmap)bmp).Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
		BitmapImage image = new BitmapImage();
		image.BeginInit();
		ms.Seek(0, SeekOrigin.Begin);
		image.StreamSource = ms;
		image.EndInit();
		return image;
	}
}
