using System;
using OpenCvSharp;


namespace OnlyOne.Video
{
    public class Video
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
                    Cv2.WaitKey(10);
                }
            }
        }


        //public void testedtest()
        //{
        //    Size dsize = new Size(640, 480);
        //  //  Size dsize = new Size(704, 576);

        //    // Opens a camera device
        //    using (VideoCapture capture = new VideoCapture(0))
        //        // Read movie frames and write them to VideoWriter 
        //    //using (VideoWriter writer = new VideoWriter("out.avi", -1, 24, dsize)) //704576
            
        //    using (VideoWriter writer = new VideoWriter("out.mp4", FourCC.Default, 20, dsize, false))
        //    using (Mat frame = new Mat())
        //    using (Mat dst = new Mat())
        //    {
        //        Console.WriteLine("Converting each movie frames...");
        //        while (true)
        //        {
        //            // Read image
        //            capture.Read(frame);
        //            if (frame.Empty())
        //                break;

        //            Console.CursorLeft = 0;
        //            Console.Write("{0} / {1}", capture.PosFrames, capture.FrameCount);

        //            // Write mat to VideoWriter
        //            writer.Write(dst);
        //        }
        //    }
        //}
    }
}
