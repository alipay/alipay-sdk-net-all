using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportDaijiaPayNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportDaijiaPayNotifyModel : AopObject
    {
        /// <summary>
        /// 优惠金额，单位分
        /// </summary>
        [XmlElement("discount_amount")]
        public long DiscountAmount { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 车生活订单No
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 支付金额，单位分
        /// </summary>
        [XmlElement("pay_amount")]
        public long PayAmount { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 订单总金额，单位分
        /// </summary>
        [XmlElement("total_amount")]
        public long TotalAmount { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
