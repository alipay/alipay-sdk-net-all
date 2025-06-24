using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommercePropertyCommunitySaveResponse.
    /// </summary>
    public class AlipayCommercePropertyCommunitySaveResponse : AopResponse
    {
        /// <summary>
        /// 项目ID
        /// </summary>
        [XmlElement("community_id")]
        public string CommunityId { get; set; }
    }
}
