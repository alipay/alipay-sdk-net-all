using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdSssQueryResponse.
    /// </summary>
    public class AlipaySecurityProdSssQueryResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("ccc")]
        public string Ccc { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("ccc_open_id")]
        public string CccOpenId { get; set; }
    }
}
