using System;
using System.Collections.Generic;
using System.Text;
using OpenCvSharp;

namespace OnlyOne.Camera
{
    public class VideoTools
    {

        public void Capture()
        {
            // Opens MP4 file (ffmpeg is probably needed)
            VideoCapture capture = new VideoCapture(0);//("aaa.mp4");
            int sleepTime = (int)Math.Round(1000 / capture.Fps);

            using (Window window = new Window("capture"))
            using (Mat image = new Mat()) // Frame image buffer
            {
                // When the movie playback reaches end, Mat.data becomes NULL.
                while (true)
                {
                    capture.Read(image); // same as cvQueryFrame
                    if (image.Empty())
                        break;

                    window.ShowImage(image);
                    //Cv2.WaitKey(sleepTime);
                    Cv2.WaitKey(0);
                }
            }
        }

        public void Save()
        {
            Size dsize = new Size(640, 480);

            // Opens a camera device
            VideoCapture capture = new VideoCapture(0);
            // Read movie frames and write them to VideoWriter 
            VideoWriter writer = new VideoWriter("D:\\Output_test\\test.avi", -1, 10, dsize);
            using (Mat frame = new Mat())
          
            using (Mat dst = new Mat())
            {
                Console.WriteLine("Converting each movie frames...");
                while (true)
                {
                    // Read image
                    capture.Read(frame);
                    if (frame.Empty())
                        break;

                    Console.CursorLeft = 0;
                    Console.Write("{0} / {1}", capture.PosFrames, capture.FrameCount);

                    // Write mat to VideoWriter
                    writer.Write(dst);
                }
            }
        }
    }
}
