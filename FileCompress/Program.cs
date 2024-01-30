// See https://aka.ms/new-console-template for more information

using FileCompress;

Console.WriteLine("Hello, World!");


string dizinYolu = @"C:\example\dizin";

string[] dosyaAdlari = Directory.GetFiles(dizinYolu);

foreach (string dosyaAdi in dosyaAdlari)
{
    Console.WriteLine(dosyaAdi);
    ImageProcessor.CompressImage(dosyaAdi, dosyaAdi);
}