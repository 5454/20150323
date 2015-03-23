using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SuperLibray {
    public class Algorithm {
        List<float> AverageSpeed(List<float> weightList, float totalTime) {
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

        List<float> GenerateWeight(float minWeight, float maxWeight, uint count) {
            List<float> rt = new List<float>();
            float lastRate = 0;
            for (int i = 0; i < count; i++) {
                lastRate += UnityEngine.Random.Range(minWeight, maxWeight);
                rt.Add(lastRate);
            }
            return rt;
        }

        List<float> GenerateWeight(float fixedRate, uint count) {
            List<float> rt = new List<float>();
            float lastRate = 0;
            for (int i = 0; i < count; i++) {
                lastRate += fixedRate;
                rt.Add(lastRate);
            }
            return rt;
        }
    }
}
