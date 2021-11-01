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
                Consts.isSaving = true;
                Random rand = new Random();

                image.Save(Consts.savePath + rand.Next(0,999).ToString());
                Consts.isSaving = false;

                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public static int SaveVideo(Bitmap image, int count)
        {
            try
            {
                image.Save(Consts.videoSavePath + count.ToString());

                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
