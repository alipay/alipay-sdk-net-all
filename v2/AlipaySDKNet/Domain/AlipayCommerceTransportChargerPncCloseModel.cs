using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportChargerPncCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportChargerPncCloseModel : AopObject
    {
        /// <summary>
        /// 支付宝用户openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 车架号ID
        /// </summary>
        [XmlElement("vin")]
        public string Vin { get; set; }
    }
}
