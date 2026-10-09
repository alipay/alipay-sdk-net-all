using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateBillServiceModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateBillServiceModifyModel : AopObject
    {
        /// <summary>
        /// 支付宝外部交易号
        /// </summary>
        [XmlElement("isv_order_no")]
        public string IsvOrderNo { get; set; }

        /// <summary>
        /// 实际付款人编号
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 交易单状态： 4-已退款
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 退款信息，交易单状态为4-已退款，退款信息不能为空
        /// </summary>
        [XmlElement("refund_info")]
        public EduRefundInfo RefundInfo { get; set; }

        /// <summary>
        /// 缴费平台的账单来源 1-ISV发送； 2-钉钉同步
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 实际付款人编号
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
