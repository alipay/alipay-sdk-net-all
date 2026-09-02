using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// McpToolList Data Structure.
    /// </summary>
    [Serializable]
    public class McpToolList : AopObject
    {
        /// <summary>
        /// 业务状态
        /// </summary>
        [XmlElement("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("input_parameter_list")]
        [XmlArrayItem("tool_parameter_infos")]
        public List<ToolParameterInfos> InputParameterList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("output_parameter_list")]
        [XmlArrayItem("tool_parameter_infos")]
        public List<ToolParameterInfos> OutputParameterList { get; set; }

        /// <summary>
        /// 工具中文名
        /// </summary>
        [XmlElement("tool_cn_name")]
        public string ToolCnName { get; set; }

        /// <summary>
        /// 工具编码
        /// </summary>
        [XmlElement("tool_code")]
        public string ToolCode { get; set; }

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

        /// <summary>
        /// 工具版本
        /// </summary>
        [XmlElement("tool_version")]
        public string ToolVersion { get; set; }
    }
}
