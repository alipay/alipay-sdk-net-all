using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportVehOrderRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportVehOrderRefundModel : AopObject
    {
        /// <summary>
        /// 车主系统订单号，商户订单同步到车主系统时，会在获取到此订单号。请注意，该订单号属于车主系统业务订单号。
        /// </summary>
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 应用维度用户ID，唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单类型，使用时务必联系业务或解决方案。
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 外部请求唯一号，代表一次退款申请，请求唯一且幂等
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 描述一个订单的退款原因
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 订单退款子订单列表
        /// </summary>
        [XmlArray("sub_order_refund_list")]
        [XmlArrayItem("sub_order_refund_request")]
        public List<SubOrderRefundRequest> SubOrderRefundList { get; set; }

        /// <summary>
        /// 支付宝收单系统交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
