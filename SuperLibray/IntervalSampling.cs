using System;
using UnityEngine;

namespace SuperLibray.U3D {
    public class IntervalSampling {

        private float samplingTime = 0f;
        private float elapsedTime = 0f;
        private float lastRealtimeSinceStartup = 0f;
        private bool pause = false;
        private Action<bool, float> action;
        public IntervalSampling(float _realtimeSinceStartup, float _samplingTime, Action<bool, float> _action) {
            samplingTime = _samplingTime;
            action = _action;
        }

        /// <summary>
        /// 使用的时候把这个方法丢到各种Update里面
        /// </summary>
        public void Sampling() {
            if (pause) return;
            elapsedTime += Time.realtimeSinceStartup - lastRealtimeSinceStartup;
            lastRealtimeSinceStartup = Time.realtimeSinceStartup;
            if (action != null) {
                action(false, samplingTime);
                if (elapsedTime >= samplingTime) {
                    elapsedTime = 0f;
                    action(true, samplingTime);
                }
            }

        }

        public void Stop() {

        }

        public bool Pause {
            set { pause = value; }
            get { return pause; }
        }

    }



}

