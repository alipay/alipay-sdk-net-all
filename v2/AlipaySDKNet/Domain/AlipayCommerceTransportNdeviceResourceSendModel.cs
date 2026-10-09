using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportNdeviceResourceSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportNdeviceResourceSendModel : AopObject
    {
        /// <summary>
        /// n设备交互配置类型
        /// </summary>
        [XmlElement("release_type")]
        public string ReleaseType { get; set; }

        /// <summary>
        /// saas平台的渠道来源
        /// </summary>
        [XmlElement("resource_channel")]
        public string ResourceChannel { get; set; }

        /// <summary>
        /// 推送资源唯一标识
        /// </summary>
        [XmlElement("resource_tag")]
        public string ResourceTag { get; set; }

        /// <summary>
        /// sn设备SN
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }
    }
}
