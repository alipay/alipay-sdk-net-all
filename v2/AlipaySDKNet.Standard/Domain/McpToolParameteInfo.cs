using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// McpToolParameteInfo Data Structure.
    /// </summary>
    [Serializable]
    public class McpToolParameteInfo : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("input_parameter_list")]
        [XmlArrayItem("tool_parameter_info")]
        public List<ToolParameterInfo> InputParameterList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("output_parameter_list")]
        [XmlArrayItem("tool_parameter_info")]
        public List<ToolParameterInfo> OutputParameterList { get; set; }

        /// <summary>
        /// 工具描述
        /// </summary>
        [XmlElement("tool_description")]
        public string ToolDescription { get; set; }

        /// <summary>
        /// 工具英文名
        /// </summary>
        [XmlElement("tool_en_name")]
        public string ToolEnName { get; set; }
    }
}
