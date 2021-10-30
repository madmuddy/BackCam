using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BackCam
{
    public static class API
    {
        public static Bitmap GetScreenShot(bool canReturn)
        {
            try
            {
                return Cam.TakeScreenShot();
            }
            catch
            {
                return new Bitmap(0, 0);
            }
        }

        public static int GetScreenShot()
        {
            try
            {
                StartUp.Configure();
                Saver.Save(Cam.TakeScreenShot());

                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
