using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitUseVO Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitUseVO : AopObject
    {
        /// <summary>
        /// 优惠金额
        /// </summary>
        [XmlElement("amount")]
        public MultiCurrencyMoneyDTO Amount { get; set; }

        /// <summary>
        /// 权益ID
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 权益类型，来自 consult 返回的 benefitType
        /// </summary>
        [XmlElement("benefit_type")]
        public string BenefitType { get; set; }

        /// <summary>
        /// 资产扩展信息
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }
    }
}
