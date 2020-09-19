using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LiabilityQuoteInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LiabilityQuoteInfo : AopObject
    {
        /// <summary>
        /// 保司返回的起保时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("effect_end_time")]
        public string EffectEndTime { get; set; }

        /// <summary>
        /// 保司返回的起保时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("effect_start_time")]
        public string EffectStartTime { get; set; }

        /// <summary>
        /// 不计免赔保费，单位分
        /// </summary>
        [XmlElement("iop_premium")]
        public string IopPremium { get; set; }

        /// <summary>
        /// 责任编码
        /// </summary>
        [XmlElement("liability_no")]
        public string LiabilityNo { get; set; }

        /// <summary>
        /// 责任保费，单位分
        /// </summary>
        [XmlElement("liability_premium")]
        public string LiabilityPremium { get; set; }

        /// <summary>
        /// 责任保额，单位分
        /// </summary>
        [XmlElement("sum_insured")]
        public string SumInsured { get; set; }
    }
}
