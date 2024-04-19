using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinSaasPaymentCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinSaasPaymentCreateModel : AopObject
    {
        /// <summary>
        /// 收单交易，acquire_order和fund_order不能同时为空
        /// </summary>
        [XmlElement("acquire_order")]
        public AcquireOrder AcquireOrder { get; set; }

        /// <summary>
        /// 资金模式，SALE销售模式用于即时到账业务；AUTH_CAPTURE预授权模式用于担保交易业务；
        /// </summary>
        [XmlElement("fund_mode")]
        public string FundMode { get; set; }

        /// <summary>
        /// 纯资金交易，充值，转账，提现等。acquire_order和fund_order不能同时为空
        /// </summary>
        [XmlElement("fund_order")]
        public FundOrder FundOrder { get; set; }

        /// <summary>
        /// 交易类型。ACQUIRE 收单业务；DEPOSIT 纯资金充值业务；TRANSFER 纯资金转账业务；WITHDRAW 纯资金提现业务
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 外部请求ID，可选
        /// </summary>
        [XmlElement("out_request_id")]
        public string OutRequestId { get; set; }

        /// <summary>
        /// 会员所属业务平台在智能科技的会员ID
        /// </summary>
        [XmlElement("platform_member_id")]
        public string PlatformMemberId { get; set; }
    }
}
