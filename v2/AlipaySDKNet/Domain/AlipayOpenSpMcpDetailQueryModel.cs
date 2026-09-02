using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpMcpDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpMcpDetailQueryModel : AopObject
    {
        /// <summary>
        /// MCP能力编码code
        /// </summary>
        [XmlElement("ability_code")]
        public string AbilityCode { get; set; }

        /// <summary>
        /// MCP版本号，不传默认查询最新版本的
        /// </summary>
        [XmlElement("ability_version")]
        public string AbilityVersion { get; set; }
    }
}
