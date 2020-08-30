using System;

namespace FinalPaintTest.Framework.Utils
{
    class File
    {
        public static string GetBase64CodeOfImage(string imgPath)
        {
            byte[] imageBytes = System.IO.File.ReadAllBytes(imgPath);
            return Convert.ToBase64String(imageBytes);
        }
    }
}
