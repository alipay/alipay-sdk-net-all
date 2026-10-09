using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SellRankWeekConfig Data Structure.
    /// </summary>
    [Serializable]
    public class SellRankWeekConfig : AopObject
    {
        /// <summary>
        /// 周显示文本
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }

        /// <summary>
        /// 一周的起始日期
        /// </summary>
        [XmlElement("week")]
        public string Week { get; set; }
    }
}
