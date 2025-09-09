using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePropertyCommunityDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePropertyCommunityDeleteModel : AopObject
    {
        /// <summary>
        /// 项目ID
        /// </summary>
        [XmlElement("community_id")]
        public string CommunityId { get; set; }
    }
}
