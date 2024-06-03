using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdJhjtestSupportauthtokenModifyResponse.
    /// </summary>
    public class AlipaySecurityProdJhjtestSupportauthtokenModifyResponse : AopResponse
    {
        /// <summary>
        /// 2
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }
    }
}
