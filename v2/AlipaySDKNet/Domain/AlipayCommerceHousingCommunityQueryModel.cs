using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHousingCommunityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHousingCommunityQueryModel : AopObject
    {
        /// <summary>
        /// 小区id
        /// </summary>
        [XmlElement("community_id")]
        public string CommunityId { get; set; }

        /// <summary>
        /// 外部小区编码
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }
    }
}
