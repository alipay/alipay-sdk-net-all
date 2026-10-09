using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AmountDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AmountDetail : AopObject
    {
        /// <summary>
        /// 总金额（元）,支持两位小数
        /// </summary>
        [XmlElement("amount_total")]
        public string AmountTotal { get; set; }

        /// <summary>
        /// 普通红包金额（元）,支持两位小数
        /// </summary>
        [XmlElement("benefit_amount")]
        public string BenefitAmount { get; set; }

        /// <summary>
        /// 授信金额（元）,支持两位小数
        /// </summary>
        [XmlElement("credit_principal_amount")]
        public string CreditPrincipalAmount { get; set; }

        /// <summary>
        /// 流量红包金额（元）,支持两位小数
        /// </summary>
        [XmlElement("marketing_amount")]
        public string MarketingAmount { get; set; }

        /// <summary>
        /// 现金金额（元）,支持两位小数
        /// </summary>
        [XmlElement("principal_amount")]
        public string PrincipalAmount { get; set; }
    }
}
