using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentProcurementInactiveCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentProcurementInactiveCheckModel : AopObject
    {
        /// <summary>
        /// 买家ID
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家ID
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 关联租赁单商户订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 关联租赁单交易组件订单号
        /// </summary>
        [XmlElement("rent_order_id")]
        public string RentOrderId { get; set; }
    }
}
