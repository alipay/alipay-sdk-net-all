using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmCarOwnerEvaluateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZmCarOwnerEvaluateInfo : AopObject
    {
        /// <summary>
        /// 芝麻车主名片顺风车主的投诉率，用小数表示，原则上精确到小数点后四位
        /// </summary>
        [XmlElement("investment_rate")]
        public string InvestmentRate { get; set; }

        /// <summary>
        /// 芝麻车主名片顺风车主的准时率，用小数表示，原则上精确到小数点后四位
        /// </summary>
        [XmlElement("on_time_rate")]
        public string OnTimeRate { get; set; }

        /// <summary>
        /// 芝麻车主名片顺风车主的好评率，用小数表示，原则上精确到小数点后四位
        /// </summary>
        [XmlElement("positive_feedback_rate")]
        public string PositiveFeedbackRate { get; set; }
    }
}
