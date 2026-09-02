using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FoodItem Data Structure.
    /// </summary>
    [Serializable]
    public class FoodItem : AopObject
    {
        /// <summary>
        /// 该项热量 kcal
        /// </summary>
        [XmlElement("calorie")]
        public string Calorie { get; set; }

        /// <summary>
        /// 食物名称
        /// </summary>
        [XmlElement("food_name")]
        public string FoodName { get; set; }

        /// <summary>
        /// 重量 g
        /// </summary>
        [XmlElement("weight_g")]
        public string WeightG { get; set; }
    }
}
