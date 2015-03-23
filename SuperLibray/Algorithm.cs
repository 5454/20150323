using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLibray {
    public class Algorithm {
        public static List<float> AverageSpeed(List<float> weightList, float totalTime) {
            List<float> rt = new List<float>();
            float totalWeight = 0;
            for (int i = 0; i < weightList.Count; i++) {
                totalWeight += weightList[i];
            }
            float averageTime = totalTime / totalWeight;
            for (int i = 0; i < weightList.Count; i++) {
                rt.Add(totalTime * averageTime);
            }
            return rt;
        }

        public static List<float> GenerateWeight(float minWeight, float maxWeight, uint count) {
            List<float> rt = new List<float>();
            float lastRate = 0;
            for (int i = 0; i < count; i++) {
                lastRate += RandomFloatRange(minWeight, maxWeight);
                rt.Add(lastRate);
            }
            return rt;
        }

        public static List<float> GenerateWeight(float fixedRate, uint count) {
            List<float> rt = new List<float>();
            float lastRate = 0;
            for (int i = 0; i < count; i++) {
                lastRate += fixedRate;
                rt.Add(lastRate);
            }
            return rt;
        }

        public static float RandomFloatRange(float minValue, float maxValue) {
            System.Random rdm = new System.Random();
            return Convert.ToSingle(rdm.NextDouble() * (maxValue - minValue));
        }


    }
}
