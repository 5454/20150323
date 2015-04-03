using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperLibray.U3D {
    public class FramePerSecond {
        private static int value = 0;
        private static int fps;
        public static int Value {
            get { return value; }
        }

        public static void Sampling(bool timeout, float samplingTime) {
            if (timeout == true) {
                value = Convert.ToInt16(fps / samplingTime);
                fps = 0;
            } else {
                fps++;
            }
        }

        public static void Sampling4GUI(bool timeout, float samplingTime) {
            SuperDebug.Log4GUI(SuperDebug.Info("FPS", Value));
        }

    }



}
