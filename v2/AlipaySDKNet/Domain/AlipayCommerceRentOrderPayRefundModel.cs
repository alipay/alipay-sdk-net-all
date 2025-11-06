using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentOrderPayRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentOrderPayRefundModel : AopObject
    {
        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 退款请求号。 标识一次退款请求，需要保证在交易号下唯一。 注：针对同一次退款请求，如果调用接口失败或异常了，重试时需要保证退款请求号不能变更，防止该笔交易重复退款。支付宝会保证同样的退款请求号多次请求只会退一次。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 支付创建时传入的商户外部交易ID
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 退款金额，单位：元，精确到小数点后两位。
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("refund_items")]
        [XmlArrayItem("rent_refund_item_d_t_o")]
        public List<RentRefundItemDTO> RefundItems { get; set; }

        /// <summary>
        /// 退款原因说明。 商家自定义，将在会在商户和用户的pc退款账单详情中展示
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
