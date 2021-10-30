using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackCam
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartUp.Configure();
                Saver.Save(Cam.TakeScreenShot());
            }
            catch
            {
            }
        }
    }
}
