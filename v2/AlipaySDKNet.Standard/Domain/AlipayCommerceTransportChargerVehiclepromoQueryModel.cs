using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportChargerVehiclepromoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportChargerVehiclepromoQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单唯一编码
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
