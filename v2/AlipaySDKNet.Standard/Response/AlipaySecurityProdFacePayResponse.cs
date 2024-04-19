using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdFacePayResponse.
    /// </summary>
    public class AlipaySecurityProdFacePayResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("aa")]
        public string Aa { get; set; }
    }
}
