using System;
using UnityEngine;

namespace SuperLibray.U3D {
    class IntervalSampling {

        private float samplingTime = 0f;
        private float elapsedTime = 0f;
        private bool pause = false;
        private Action procedure;

        public void Sampling() {
            if (pause) return;
            elapsedTime += Time.deltaTime;
            if (elapsedTime >= samplingTime * Time.timeScale) {
                if (procedure != null) {
                    elapsedTime = 0f;
                    procedure();
                }
            }
        }

        public IntervalSampling(float time, Action action) {
            samplingTime = time;
            procedure = action;
        }

        public void Stop() {

        }

        public bool Pause {
            set { pause = value; }
            get { return pause; }
        }

    }
}

