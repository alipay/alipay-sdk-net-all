using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHotelOrderRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHotelOrderRefundModel : AopObject
    {
        /// <summary>
        /// 出行酒店订单id
        /// </summary>
        [XmlElement("alipay_hotel_order_id")]
        public string AlipayHotelOrderId { get; set; }

        /// <summary>
        /// 买家open_id；
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户订单号，创建订单请求由商户传入；
        /// </summary>
        [XmlElement("outer_order_id")]
        public string OuterOrderId { get; set; }

        /// <summary>
        /// 枚举值： 未入住：NOSHOW 提前离店：EARLY_DEPARTURE
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 当noshow或提前离店时，应退用户金额
        /// </summary>
        [XmlElement("refund_amount")]
        public EtravelHotelSupplyPriceDTO RefundAmount { get; set; }

        /// <summary>
        /// 退款流水号，幂等控制
        /// </summary>
        [XmlElement("refund_bill_no")]
        public string RefundBillNo { get; set; }
    }
}
