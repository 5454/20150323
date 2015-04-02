using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperLibray {
    public class Algorithm {
        /// <summary>
        /// 根据权重列表计算权重时间
        /// </summary>
        /// <param name="weightList">权重列表</param>
        /// <param name="totalTime">总时间</param>
        /// <returns>权重时间</returns>
        public static List<float> AverageSpeed(List<float> weightList, float totalTime) {
            List<float> rt = new List<float>();
            float totalWeight = weightList.Sum();
            float averageTime = totalTime / totalWeight;
            for (int i = 0; i < weightList.Count; i++) {
                rt.Add(weightList[i] * averageTime);
            }
            return rt;
        }

        /// <summary>
        /// 按照指定范围内的随机增长或衰减比率获取指定长度的权重列表
        /// </summary>
        /// <param name="minWeight">最小范围权重</param>
        /// <param name="maxWeight">最大范围权重</param>
        /// <param name="count">列表长度</param>
        /// <param name="increase">是增长,否递减</param>
        /// <returns>返回随机增长率权重列表</returns>
        public static List<float> GenerateWeight(float minWeight, float maxWeight, int count, bool increase = true) {
            List<float> rt = new List<float>();
            float lastRate = 0;
            for (int i = 0; i < count; i++) {
                lastRate += RandomFloatRange(minWeight, maxWeight);
                rt.Add(lastRate);
            }
            if (increase == false) rt.Reverse();
            return rt;
        }

        /// <summary>
        /// 按照固定增长或衰减比率获取指定长度的权重列表
        /// </summary>
        /// <param name="fixedRate">固定增长或衰减比率</param>
        /// <param name="count">列表长度</param>
        /// <param name="increase">是增长,否递减</param>
        /// <returns>返回固定增长率权重列表</returns>
        public static List<float> GenerateWeight(float fixedRate, int count, bool increase = true) {
            List<float> rt = new List<float>();
            float lastRate = 0;
            for (int i = 0; i < count; i++) {
                lastRate += fixedRate;
                rt.Add(lastRate);
            }
            if (increase == false) rt.Reverse();
            return rt;
        }

        /// <summary>
        /// 获取某个范围内的浮点随机数
        /// </summary>
        /// <param name="minValue">最小值</param>
        /// <param name="maxValue">最大值</param>
        /// <returns>返回随机浮点数</returns>
        public static float RandomFloatRange(float minValue, float maxValue) {
            System.Random rdm = new System.Random();
            return Convert.ToSingle(rdm.NextDouble() * (maxValue - minValue));
        }

        public static void UpdateTest(){
        }
    }
}
