﻿using System;
using OpenCvSharp;


namespace OnlyOne.Video
{
    public class Video
    {
        private bool captureInProgress;

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
    }
}
