using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitAmount Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitAmount : AopObject
    {
        /// <summary>
        /// 优惠的名称
        /// </summary>
        [XmlElement("benefit_desc")]
        public string BenefitDesc { get; set; }

        /// <summary>
        /// 辅营带来的收益的金额
        /// </summary>
        [XmlElement("benefit_money")]
        public string BenefitMoney { get; set; }

        /// <summary>
        /// ● CASH_BACK：返现 ● CUT：立减 ● COUPON：优惠券
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
