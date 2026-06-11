using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportVehownerbaseVehicleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportVehownerbaseVehicleQueryModel : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 车辆 ID
        /// </summary>
        [XmlElement("vi_id")]
        public string ViId { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("vi_number")]
        public string ViNumber { get; set; }
    }
}
