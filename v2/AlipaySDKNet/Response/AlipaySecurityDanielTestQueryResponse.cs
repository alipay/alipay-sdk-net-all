using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityDanielTestQueryResponse.
    /// </summary>
    public class AlipaySecurityDanielTestQueryResponse : AopResponse
    {
        /// <summary>
        /// 12
        /// </summary>
        [XmlElement("out_param")]
        public string OutParam { get; set; }
    }
}
