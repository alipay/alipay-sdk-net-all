using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataservicePropertyBusinesspropertyCreateResponse.
    /// </summary>
    public class AlipayDataDataservicePropertyBusinesspropertyCreateResponse : AopResponse
    {
        /// <summary>
        /// 业务画像标签id
        /// </summary>
        [XmlElement("business_property_id")]
        public string BusinessPropertyId { get; set; }
    }
}
