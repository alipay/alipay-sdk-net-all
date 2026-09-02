using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ToolInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ToolInfo : AopObject
    {
        /// <summary>
        /// 工具code
        /// </summary>
        [XmlElement("tool_code")]
        public string ToolCode { get; set; }

        /// <summary>
        /// 工具英文名
        /// </summary>
        [XmlElement("tool_en_name")]
        public string ToolEnName { get; set; }
    }
}
