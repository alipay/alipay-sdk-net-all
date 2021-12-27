using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinSaasPaymentCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinSaasPaymentCancelModel : AopObject
    {
        /// <summary>
        /// 撤销金额，单位为元。支持预授权后全额撤销、或预授权后部分撤销。精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("cancel_amount")]
        public string CancelAmount { get; set; }

        /// <summary>
        /// 支付币种三位字母编码。（编码规则遵循https://zh.wikipedia.org/wiki/ISO_4217）
        /// </summary>
        [XmlElement("cancel_currency")]
        public string CancelCurrency { get; set; }

        /// <summary>
        /// 外部业务平台原始交易号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 付款方外部业务平台会员ID
        /// </summary>
        [XmlElement("out_payer_id")]
        public ReferenceId OutPayerId { get; set; }

        /// <summary>
        /// 外部请求ID
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
