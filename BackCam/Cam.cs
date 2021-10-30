using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

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
    }
}
