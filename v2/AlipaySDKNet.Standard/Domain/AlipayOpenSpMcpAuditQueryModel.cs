using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpMcpAuditQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpMcpAuditQueryModel : AopObject
    {
        /// <summary>
        /// MCP能力编码code
        /// </summary>
        [XmlElement("ability_code")]
        public string AbilityCode { get; set; }
    }
}
