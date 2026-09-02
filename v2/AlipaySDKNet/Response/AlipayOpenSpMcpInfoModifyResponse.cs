using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpMcpInfoModifyResponse.
    /// </summary>
    public class AlipayOpenSpMcpInfoModifyResponse : AopResponse
    {
        /// <summary>
        /// MCP能力编码code
        /// </summary>
        [XmlElement("ability_code")]
        public string AbilityCode { get; set; }

        /// <summary>
        /// MCP版本号
        /// </summary>
        [XmlElement("ability_version")]
        public string AbilityVersion { get; set; }
    }
}
