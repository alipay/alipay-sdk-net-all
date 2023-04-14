using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentClauseDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentClauseDetailDTO : AopObject
    {
        /// <summary>
        /// 支付条目金额，单位元，人民币
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 支付条目备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 资金转入资产主体
        /// </summary>
        [XmlElement("trans_in_principal")]
        public WitnessPrincipalDTO TransInPrincipal { get; set; }

        /// <summary>
        /// 资金转出资产主体
        /// </summary>
        [XmlElement("trans_out_principal")]
        public WitnessPrincipalDTO TransOutPrincipal { get; set; }
    }
}
