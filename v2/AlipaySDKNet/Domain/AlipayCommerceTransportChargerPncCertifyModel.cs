using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportChargerPncCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportChargerPncCertifyModel : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        [XmlElement("vin")]
        public string Vin { get; set; }
    }
}
