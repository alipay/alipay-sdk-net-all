using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpMcpAuditSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpMcpAuditSubmitModel : AopObject
    {
        /// <summary>
        /// MCP能力编码code
        /// </summary>
        [XmlElement("ability_code")]
        public string AbilityCode { get; set; }
    }
}
