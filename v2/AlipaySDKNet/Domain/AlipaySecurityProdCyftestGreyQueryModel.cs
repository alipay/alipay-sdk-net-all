using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdCyftestGreyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdCyftestGreyQueryModel : AopObject
    {
        /// <summary>
        /// asdf
        /// </summary>
        [XmlElement("testone")]
        public string Testone { get; set; }
    }
}
