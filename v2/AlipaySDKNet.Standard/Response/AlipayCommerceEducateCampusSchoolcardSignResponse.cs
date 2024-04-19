using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateCampusSchoolcardSignResponse.
    /// </summary>
    public class AlipayCommerceEducateCampusSchoolcardSignResponse : AopResponse
    {
        /// <summary>
        /// 开通成功，返回的schema
        /// </summary>
        [XmlElement("schema_url")]
        public string SchemaUrl { get; set; }
    }
}
