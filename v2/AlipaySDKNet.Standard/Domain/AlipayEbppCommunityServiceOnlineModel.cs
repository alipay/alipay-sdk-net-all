using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppCommunityServiceOnlineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppCommunityServiceOnlineModel : AopObject
    {
        /// <summary>
        /// 小区短名
        /// </summary>
        [XmlElement("community_short_name")]
        public string CommunityShortName { get; set; }

        /// <summary>
        /// 服务类型
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }
    }
}
