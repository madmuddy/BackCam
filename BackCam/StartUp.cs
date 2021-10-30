using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BackCam
{
    static class StartUp
    {
        public static int Configure()
        {
            try
            {
                Consts.programPath = Directory.GetCurrentDirectory();
                Consts.tempPath = Path.GetTempPath();
                Consts.savePath = Path.Combine(Consts.tempPath, Consts.saveFileName);

                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
