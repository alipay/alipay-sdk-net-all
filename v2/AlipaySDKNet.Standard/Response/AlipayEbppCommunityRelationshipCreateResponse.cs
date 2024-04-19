using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppCommunityRelationshipCreateResponse.
    /// </summary>
    public class AlipayEbppCommunityRelationshipCreateResponse : AopResponse
    {
        /// <summary>
        /// 物业和小区的绑定实体ID
        /// </summary>
        [XmlElement("relationship_id")]
        public string RelationshipId { get; set; }
    }
}
