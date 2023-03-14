using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryOnecodepassOrderRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryOnecodepassOrderRefundModel : AopObject
    {
        /// <summary>
        /// 机构编码，接入时由支付宝小二分配
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 退款请求号。 标识一次退款请求，需要保证在交易号下唯一，如需部分退款，则此参数必传。 注：针对同一次退款请求，如果调用接口失败或异常了，重试时需要保证退款请求号不能变更，防止该笔交易重复退款。支付宝会保证同样的退款请求号多次请求只会退一次。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户订单号。 和支付宝交易号不能同时为空
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 退款金额。 需要退款的金额，该金额不能大于订单金额，单位为元，支持两位小数。 如果不传，默认全额退款。
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款原因说明。商家自定义，将在会在商户和用户的pc退款账单详情中展示
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 卖家支付宝用户ID。 商户订单号不为空时，卖家支付宝用户ID必选
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 支付宝交易号，和支付宝交易号不能同时为空
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
