using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppCommunityServiceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppCommunityServiceQueryModel : AopObject
    {
        /// <summary>
        /// 小区短名
        /// </summary>
        [XmlElement("community_short_name")]
        public string CommunityShortName { get; set; }
    }
}
