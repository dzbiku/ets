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


        public void testedtest()
        {
            Size dsize = new Size(640, 480);

            // Opens a camera device
            using (VideoCapture capture = new VideoCapture(0))
                // Read movie frames and write them to VideoWriter 
            using (VideoWriter writer = new VideoWriter("out.avi", -1, 25, dsize))
            using (Mat frame = new Mat())
            using (Mat gray = new Mat())
            using (Mat canny = new Mat())
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

                    // grayscale -> canny -> resize
                    Cv2.CvtColor(frame, gray, ColorConversionCodes.BGR2GRAY);
                    Cv2.Canny(gray, canny, 100, 180);
                    Cv2.Resize(canny, dst, dsize, 0, 0, InterpolationFlags.Linear);
                    // Write mat to VideoWriter
                    writer.Write(dst);
                }
            }
        }
    }
}
