using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlcoholHistory Data Structure.
    /// </summary>
    [Serializable]
    public class AlcoholHistory : AopObject
    {
        /// <summary>
        /// 是否戒酒（Y/N）
        /// </summary>
        [XmlElement("alcohol_abstinence")]
        public string AlcoholAbstinence { get; set; }

        /// <summary>
        /// 饮酒种类(白酒、黄酒）
        /// </summary>
        [XmlElement("alcohol_type")]
        public string AlcoholType { get; set; }

        /// <summary>
        /// 饮酒频率
        /// </summary>
        [XmlElement("drink_frequency")]
        public DrinkFrequency DrinkFrequency { get; set; }

        /// <summary>
        /// 日饮酒量单位 ml/两
        /// </summary>
        [XmlElement("drinking")]
        public string Drinking { get; set; }

        /// <summary>
        /// 饮酒时长（年）
        /// </summary>
        [XmlElement("drinking_time")]
        public string DrinkingTime { get; set; }

        /// <summary>
        /// 饮酒时长单位 年
        /// </summary>
        [XmlElement("drinking_time_unit")]
        public string DrinkingTimeUnit { get; set; }

        /// <summary>
        ///   "drinkingUnit": "两", //单位 ml/两
        /// </summary>
        [XmlElement("drinking_unit")]
        public string DrinkingUnit { get; set; }

        /// <summary>
        /// 戒酒时间（最后一次饮酒时间）
        /// </summary>
        [XmlElement("last_drink")]
        public string LastDrink { get; set; }
    }
}
