using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoCityserviceExtOrdercompleteQueryResponse.
    /// </summary>
    public class AlipayEcoCityserviceExtOrdercompleteQueryResponse : AopResponse
    {
        /// <summary>
        /// 交易订单是否完成计费 收费字段。  1 未核销 2 已核销
        /// </summary>
        [XmlElement("order_complete_status")]
        public string OrderCompleteStatus { get; set; }

        /// <summary>
        /// 退款请求号，当order_type=2时必传。 标识一次退款请求，需要保证在外部交易号下唯一。 注：针对同一次退款请求，如果调用接口失败或异常了，重试时需要保证退款请求号不能变更，防止该笔交易重复退款。支付宝会保证同样的退款请求号多次请求只会退一次。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户订单号，最大长度64字符，需保证商户侧不重复。注意：退费时该参数需要和收费时保持一致，否则无法退费
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }
    }
}
