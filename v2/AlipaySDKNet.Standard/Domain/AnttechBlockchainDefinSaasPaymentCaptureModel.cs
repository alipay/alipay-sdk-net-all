using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinSaasPaymentCaptureModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinSaasPaymentCaptureModel : AopObject
    {
        /// <summary>
        /// 请款金额，单位为元。支持预授权后全额请款、或预授权后先部分撤销再部分请款。精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("capture_amount")]
        public string CaptureAmount { get; set; }

        /// <summary>
        /// 支付币种三位字母编码。（编码规则遵循https://zh.wikipedia.org/wiki/ISO_4217）
        /// </summary>
        [XmlElement("capture_currency")]
        public string CaptureCurrency { get; set; }

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
