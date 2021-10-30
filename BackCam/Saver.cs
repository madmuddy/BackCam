using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace BackCam
{
    static class Saver
    {
        public static int Save(Bitmap image)
        {
            try
            {
                Random rand = new Random();

                image.Save(Consts.savePath + rand.Next(0,999).ToString());

                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
