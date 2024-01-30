using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Formats.Webp;

namespace FileCompress;

public class ImageProcessor
{
    public static void CompressImage(string inputPath, string outputPath, int? quality = 40)
    {
        using (var image = Image.Load(inputPath))
        {
            image.Save(outputPath, new JpegEncoder { Quality = quality });
        }
    }

    public static void CompressImagePngEncoder(string inputPath, string outputPath)
    {
        using (var image = Image.Load(inputPath))
        {
            image.Save(outputPath, new PngEncoder());
        }
    }

    public static void CompressImageWebpEncoder(string inputPath, string outputPath)
    {
        using (var image = Image.Load(inputPath))
        {
            image.Save(outputPath, new WebpEncoder());
        }
    }
}