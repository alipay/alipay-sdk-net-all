using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskDeviceinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskDeviceinfoQueryModel : AopObject
    {
        /// <summary>
        /// 渠道的唯一标识
        /// </summary>
        [XmlElement("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 手机号码的SHA256值
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }
    }
}
