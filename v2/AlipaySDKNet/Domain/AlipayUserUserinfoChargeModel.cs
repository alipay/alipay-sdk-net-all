using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserUserinfoChargeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserUserinfoChargeModel : AopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address_type")]
        public string AddressType { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("sdddd")]
        public bool Sdddd { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
