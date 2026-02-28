using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalDoctoravatarinfoQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalDoctoravatarinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 原始图片地址
        /// </summary>
        [XmlElement("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 头像地址
        /// </summary>
        [XmlElement("discovery_page_avatar")]
        public string DiscoveryPageAvatar { get; set; }

        /// <summary>
        /// 状态 
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 欢迎页头像地址
        /// </summary>
        [XmlElement("welcome_card_avatar")]
        public string WelcomeCardAvatar { get; set; }
    }
}
