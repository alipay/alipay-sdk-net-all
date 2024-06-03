using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SellRankMonthConfig Data Structure.
    /// </summary>
    [Serializable]
    public class SellRankMonthConfig : AopObject
    {
        /// <summary>
        /// 月份
        /// </summary>
        [XmlElement("month")]
        public string Month { get; set; }

        /// <summary>
        /// 文本
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
