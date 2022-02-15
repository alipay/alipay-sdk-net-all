using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdHaiguanNolabelCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdHaiguanNolabelCreateModel : AopObject
    {
        /// <summary>
        /// 23
        /// </summary>
        [XmlElement("one")]
        public string One { get; set; }
    }
}
