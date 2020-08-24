using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdFacePayCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdFacePayCreateModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("aaa")]
        public string Aaa { get; set; }

        /// <summary>
        /// 2
        /// </summary>
        [XmlElement("aaaaaaaaaaaaa")]
        public string Aaaaaaaaaaaaa { get; set; }
    }
}
