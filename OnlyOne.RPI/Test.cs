using System;
using System.IO;
using Unosquare.RaspberryIO;

namespace OnlyOne.RPI
{
    public class Test
    {
        /// <summary>
        /// For build in camera- dedicated, not for usb camera. 
        /// </summary>
        public void TestCaptureImage()
        {
            var pictureBytes = Pi.Camera.CaptureImageJpeg(640, 480);
            var targetPath = "/home/pi/picture.jpg";
            if (File.Exists(targetPath))
                File.Delete(targetPath);

            File.WriteAllBytes(targetPath, pictureBytes);
            Console.WriteLine($"Took picture -- Byte count: {pictureBytes.Length}");
        }
    }
}
