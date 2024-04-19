using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniPublicRelationQueryResponse.
    /// </summary>
    public class AlipayOpenMiniPublicRelationQueryResponse : AopResponse
    {
        /// <summary>
        /// 生活号ID
        /// </summary>
        [XmlElement("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// 生活号名称
        /// </summary>
        [XmlElement("public_name")]
        public string PublicName { get; set; }
    }
}
