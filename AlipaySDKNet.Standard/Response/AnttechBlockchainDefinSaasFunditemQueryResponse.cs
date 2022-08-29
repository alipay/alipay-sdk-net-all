using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinSaasFunditemQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinSaasFunditemQueryResponse : AopResponse
    {
        /// <summary>
        /// 资金操作类型。CAPTURE(请款);CANCEL(撤销/退款);
        /// </summary>
        [XmlElement("fund_type")]
        public string FundType { get; set; }

        /// <summary>
        /// 外部业务平台原始交易号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

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

        /// <summary>
        /// 本次请求金额，单位为元。
        /// </summary>
        [XmlElement("request_amount")]
        public string RequestAmount { get; set; }

        /// <summary>
        /// 支付币种三位字母编码。（编码规则遵循https://zh.wikipedia.org/wiki/ISO_4217）
        /// </summary>
        [XmlElement("request_currency")]
        public string RequestCurrency { get; set; }

        /// <summary>
        /// 资金操作状态。PROCESSING(处理中);SUCCESS(成功);FAIL(失败);
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }
    }
}
