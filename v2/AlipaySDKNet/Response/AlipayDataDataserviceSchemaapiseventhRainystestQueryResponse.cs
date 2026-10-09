using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceSchemaapiseventhRainystestQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceSchemaapiseventhRainystestQueryResponse : AopResponse
    {
        /// <summary>
        /// id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
