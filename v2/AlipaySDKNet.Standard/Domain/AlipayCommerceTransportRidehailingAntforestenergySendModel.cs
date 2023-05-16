using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportRidehailingAntforestenergySendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportRidehailingAntforestenergySendModel : AopObject
    {
        /// <summary>
        /// 蚂蚁森林能量发放订单号
        /// </summary>
        [XmlElement("ant_forest_order_id")]
        public string AntForestOrderId { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("car_no")]
        public string CarNo { get; set; }

        /// <summary>
        /// 发放蚂蚁森林能量的应用Id
        /// </summary>
        [XmlElement("ride_hailing_app_id")]
        public string RideHailingAppId { get; set; }

        /// <summary>
        /// 网约车行程订单ID
        /// </summary>
        [XmlElement("ride_hailing_order_id")]
        public string RideHailingOrderId { get; set; }

        /// <summary>
        /// 网约车发放蚂蚁森林能量的pid
        /// </summary>
        [XmlElement("ride_hailing_partner_id")]
        public string RideHailingPartnerId { get; set; }

        /// <summary>
        /// 支付宝交易单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
