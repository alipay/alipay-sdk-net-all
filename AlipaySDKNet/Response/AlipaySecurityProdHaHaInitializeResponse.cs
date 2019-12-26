using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdHaHaInitializeResponse.
    /// </summary>
    public class AlipaySecurityProdHaHaInitializeResponse : AopResponse
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }
    }
}
