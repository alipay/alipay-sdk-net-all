using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpMcpDetailQueryResponse.
    /// </summary>
    public class AlipayOpenSpMcpDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// MCP能力编码状态
        /// </summary>
        [XmlElement("ability_status")]
        public string AbilityStatus { get; set; }

        /// <summary>
        /// MCP能力编码版本
        /// </summary>
        [XmlElement("ability_version")]
        public string AbilityVersion { get; set; }

        /// <summary>
        /// Header参数列表
        /// </summary>
        [XmlElement("header_list")]
        public HeaderParam HeaderList { get; set; }

        /// <summary>
        /// MCP图标文件链接
        /// </summary>
        [XmlElement("icon_url")]
        public string IconUrl { get; set; }

        /// <summary>
        /// MCP中文名
        /// </summary>
        [XmlElement("mcp_chinese_name")]
        public string McpChineseName { get; set; }

        /// <summary>
        /// MCP描述
        /// </summary>
        [XmlElement("mcp_desc")]
        public string McpDesc { get; set; }

        /// <summary>
        /// MCP英文名
        /// </summary>
        [XmlElement("mcp_english_name")]
        public string McpEnglishName { get; set; }

        /// <summary>
        /// MCP服务URL
        /// </summary>
        [XmlElement("mcp_server_url")]
        public string McpServerUrl { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("mcp_tool_list")]
        [XmlArrayItem("mcp_tool_list")]
        public List<McpToolList> McpToolList { get; set; }

        /// <summary>
        /// 请求超时时间(ms)
        /// </summary>
        [XmlElement("request_timeout")]
        public long RequestTimeout { get; set; }

        /// <summary>
        /// 响应超时时间(ms)
        /// </summary>
        [XmlElement("response_timeout")]
        public long ResponseTimeout { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("support_account_type_list")]
        [XmlArrayItem("string")]
        public List<string> SupportAccountTypeList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("support_protocols")]
        [XmlArrayItem("string")]
        public List<string> SupportProtocols { get; set; }
    }
}
