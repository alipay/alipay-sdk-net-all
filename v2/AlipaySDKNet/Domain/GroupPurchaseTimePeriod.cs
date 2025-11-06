using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupPurchaseTimePeriod Data Structure.
    /// </summary>
    [Serializable]
    public class GroupPurchaseTimePeriod : AopObject
    {
        /// <summary>
        /// 营业结束时间
        /// </summary>
        [XmlElement("end")]
        public string End { get; set; }

        /// <summary>
        /// 营业结束时间是下一天
        /// </summary>
        [XmlElement("end_next_day")]
        public bool EndNextDay { get; set; }

        /// <summary>
        /// 营业开始时间
        /// </summary>
        [XmlElement("start")]
        public string Start { get; set; }
    }
}
