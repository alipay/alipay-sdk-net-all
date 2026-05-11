using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CycleAvgDiscountAmountConfig Data Structure.
    /// </summary>
    [Serializable]
    public class CycleAvgDiscountAmountConfig : AopObject
    {
        /// <summary>
        /// 当前周期均价，单位：分
        /// </summary>
        [XmlElement("avg_discount_amount")]
        public long AvgDiscountAmount { get; set; }

        /// <summary>
        /// 指定周期均价配置中的周期
        /// </summary>
        [XmlArray("day_of_week")]
        [XmlArrayItem("string")]
        public List<string> DayOfWeek { get; set; }

        /// <summary>
        /// 指定周期配置的顺序
        /// </summary>
        [XmlElement("order")]
        public long Order { get; set; }
    }
}
