using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PsbHotelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PsbHotelInfo : AopObject
    {
        /// <summary>
        /// PSB中台将酒店授权给PSB服务商待调用的授权码
        /// </summary>
        [XmlElement("license_key")]
        public string LicenseKey { get; set; }

        /// <summary>
        /// PSB服务商的标识，请提前联系支付宝技术人员来配置
        /// </summary>
        [XmlElement("psb_code")]
        public string PsbCode { get; set; }

        /// <summary>
        /// PSB服务商侧维护的酒店唯一标识
        /// </summary>
        [XmlElement("psb_hotel_id")]
        public string PsbHotelId { get; set; }
    }
}
