using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityDataInnerouterTestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityDataInnerouterTestQueryModel : AopObject
    {
        /// <summary>
        /// 32
        /// </summary>
        [XmlElement("one")]
        public string One { get; set; }
    }
}
