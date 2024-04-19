using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// HuanxuTradeOrderRefundResponse.
    /// </summary>
    public class HuanxuTradeOrderRefundResponse : AopResponse
    {
        /// <summary>
        /// 聚合支付的支付渠道，焕旭分配。
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 用于透传扩展信息，pay_url为支付链接。
        /// </summary>
        [XmlElement("ext_context")]
        public ExtContext ExtContext { get; set; }

        /// <summary>
        /// 退款金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款指令id，焕旭针对每一笔退款请求生成的唯一退款凭证号
        /// </summary>
        [XmlElement("refund_id")]
        public string RefundId { get; set; }

        /// <summary>
        /// 退款请求号，对应一笔业务订单下的一次退款请求，不退款请求需保证请求号唯一
        /// </summary>
        [XmlElement("refund_request_no")]
        public string RefundRequestNo { get; set; }

        /// <summary>
        /// 退款状态，目前支持如下值： SUCCESS（退款成功），该状态表示该笔退款已成功处理； FAIL（退款失败），该状态表示该笔退款已失败，并且不可重试，后续如果要重新退款，需要更换退款请求号。
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }
    }
}
