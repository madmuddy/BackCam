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

        public static int GetScreenShot(Config conf)
        {
            try
            {
                Consts.programPath = conf.programPath;
                Consts.tempPath = conf.tempPath;
                Consts.savePath = conf.savePath;
                Consts.saveFileName = conf.saveFileName;
                Consts.videoSaveFileName = conf.videoSaveFileName;
                Consts.videoSavePath = conf.videoSavePath;
                Consts.isSaving = conf.isSaving;
                Consts.canRecord = conf.canRecord;
                Consts.sleepTime = conf.sleepTime;

                Saver.Save(Cam.TakeScreenShot());

                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public static int GetVideo(Config conf)
        {
            try
            {
                Consts.programPath = conf.programPath;
                Consts.tempPath = conf.tempPath;
                Consts.savePath = conf.savePath;
                Consts.saveFileName = conf.saveFileName;
                Consts.videoSaveFileName = conf.videoSaveFileName;
                Consts.videoSavePath = conf.videoSavePath;
                Consts.isSaving = conf.isSaving;
                Consts.canRecord = conf.canRecord;
                Consts.sleepTime = conf.sleepTime;

                Cam.TakeVideo();

                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public struct Config
        {
            public string programPath;
            public string tempPath;

            public string savePath;
            public string saveFileName;

            public string videoSavePath;
            public string videoSaveFileName;

            public bool isSaving;
            public bool canRecord;

            public int sleepTime;
        }
    }
}
