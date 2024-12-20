using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PenaltyPercent Data Structure.
    /// </summary>
    [Serializable]
    public class PenaltyPercent : AopObject
    {
        /// <summary>
        /// 罚金晚数
        /// </summary>
        [XmlElement("nights")]
        public long Nights { get; set; }

        /// <summary>
        /// 罚金百分比
        /// </summary>
        [XmlElement("percent")]
        public string Percent { get; set; }
    }
}
