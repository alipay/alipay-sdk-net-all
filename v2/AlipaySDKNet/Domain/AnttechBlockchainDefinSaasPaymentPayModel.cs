using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinSaasPaymentPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinSaasPaymentPayModel : AopObject
    {
        /// <summary>
        /// 支付时间
        /// </summary>
        [XmlElement("order_pay_time")]
        public string OrderPayTime { get; set; }

        /// <summary>
        /// 外部业务平台原始交易号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 收款方外部业务平台会员ID
        /// </summary>
        [XmlElement("out_payee_id")]
        public ReferenceId OutPayeeId { get; set; }

        /// <summary>
        /// 付款方外部业务平台会员ID
        /// </summary>
        [XmlElement("out_payer_id")]
        public ReferenceId OutPayerId { get; set; }

        /// <summary>
        /// 付款明细
        /// </summary>
        [XmlElement("payer_detail")]
        public PayerDetailVO PayerDetail { get; set; }

        /// <summary>
        /// 会员所属业务平台在智能科技的会员ID
        /// </summary>
        [XmlElement("platform_member_id")]
        public string PlatformMemberId { get; set; }
    }
}
