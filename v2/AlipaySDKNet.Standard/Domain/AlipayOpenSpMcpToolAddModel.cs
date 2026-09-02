using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpMcpToolAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpMcpToolAddModel : AopObject
    {
        /// <summary>
        /// MCP能力编码code
        /// </summary>
        [XmlElement("ability_code")]
        public string AbilityCode { get; set; }

        /// <summary>
        /// 添加方式：1-自动拉取，2-手动添加
        /// </summary>
        [XmlElement("add_type")]
        public string AddType { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("mcp_tool_info_list")]
        [XmlArrayItem("mcp_tool_paramete_info")]
        public List<McpToolParameteInfo> McpToolInfoList { get; set; }
    }
}
