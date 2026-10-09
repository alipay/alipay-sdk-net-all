using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpMcpDebugSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpMcpDebugSubmitModel : AopObject
    {
        /// <summary>
        /// MCP能力编码code
        /// </summary>
        [XmlElement("ability_code")]
        public string AbilityCode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("headers")]
        [XmlArrayItem("name_value_param")]
        public List<NameValueParam> Headers { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("query_params")]
        [XmlArrayItem("name_value_param")]
        public List<NameValueParam> QueryParams { get; set; }

        /// <summary>
        /// 工具编码
        /// </summary>
        [XmlElement("tool_code")]
        public string ToolCode { get; set; }

        /// <summary>
        /// 工具调试报文JSON
        /// </summary>
        [XmlElement("tool_schema")]
        public string ToolSchema { get; set; }
    }
}
