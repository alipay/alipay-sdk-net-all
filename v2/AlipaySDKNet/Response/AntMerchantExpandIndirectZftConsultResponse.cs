using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectZftConsultResponse.
    /// </summary>
    public class AntMerchantExpandIndirectZftConsultResponse : AopResponse
    {
        /// <summary>
        /// 资金账户是否审核。当调用没有报错时，本值才有参考意义
        /// </summary>
        [XmlElement("account_audit")]
        public bool AccountAudit { get; set; }

        /// <summary>
        /// 咨询申请单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 是否风控审核。当调用没有报错时，本值才有参考意义
        /// </summary>
        [XmlElement("risk_audit")]
        public bool RiskAudit { get; set; }
    }
}
