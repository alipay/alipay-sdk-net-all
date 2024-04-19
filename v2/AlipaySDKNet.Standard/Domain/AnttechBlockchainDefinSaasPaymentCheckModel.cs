using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinSaasPaymentCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinSaasPaymentCheckModel : AopObject
    {
        /// <summary>
        /// 资金模式，SALE销售模式用于即时到账业务；AUTH_CAPTURE预授权模式用于担保交易业务；
        /// </summary>
        [XmlElement("fund_mode")]
        public string FundMode { get; set; }

        /// <summary>
        /// 交易类型。ACQUIRE 收单业务；DEPOSIT 纯资金充值业务；TRANSFER 纯资金转账业务；WITHDRAW 纯资金提现业务
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 收款方外部业务平台会员
        /// </summary>
        [XmlElement("payee_out_member_id")]
        public ReferenceId PayeeOutMemberId { get; set; }

        /// <summary>
        /// 付款方外部业务平台会员
        /// </summary>
        [XmlElement("payer_out_member_id")]
        public ReferenceId PayerOutMemberId { get; set; }

        /// <summary>
        /// 会员所属业务平台在智能科技的会员ID
        /// </summary>
        [XmlElement("platform_member_id")]
        public string PlatformMemberId { get; set; }
    }
}
