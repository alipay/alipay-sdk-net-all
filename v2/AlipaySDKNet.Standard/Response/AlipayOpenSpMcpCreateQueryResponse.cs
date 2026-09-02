using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpMcpCreateQueryResponse.
    /// </summary>
    public class AlipayOpenSpMcpCreateQueryResponse : AopResponse
    {
        /// <summary>
        /// MCP能力编码code
        /// </summary>
        [XmlElement("ability_code")]
        public string AbilityCode { get; set; }

        /// <summary>
        /// MCP中文名
        /// </summary>
        [XmlElement("mcp_chinese_name")]
        public string McpChineseName { get; set; }

        /// <summary>
        /// MCP英文名
        /// </summary>
        [XmlElement("mcp_english_name")]
        public string McpEnglishName { get; set; }

        /// <summary>
        /// 申请单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
