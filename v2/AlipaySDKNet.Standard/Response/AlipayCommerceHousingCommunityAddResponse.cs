using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceHousingCommunityAddResponse.
    /// </summary>
    public class AlipayCommerceHousingCommunityAddResponse : AopResponse
    {
        /// <summary>
        /// 小区id
        /// </summary>
        [XmlElement("community_id")]
        public string CommunityId { get; set; }
    }
}
