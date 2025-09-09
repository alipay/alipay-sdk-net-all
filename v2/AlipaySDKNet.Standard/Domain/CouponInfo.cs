using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CouponInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CouponInfo : AopObject
    {
        /// <summary>
        /// 权益id
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 权益类型
        /// </summary>
        [XmlElement("benefit_type")]
        public string BenefitType { get; set; }
    }
}
