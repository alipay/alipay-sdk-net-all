using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAntestAppversionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAntestAppversionQueryModel : AopObject
    {
        /// <summary>
        /// appId
        /// </summary>
        [XmlElement("app_code")]
        public string AppCode { get; set; }
    }
}
