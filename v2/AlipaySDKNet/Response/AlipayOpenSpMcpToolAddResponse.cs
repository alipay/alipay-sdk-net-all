using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpMcpToolAddResponse.
    /// </summary>
    public class AlipayOpenSpMcpToolAddResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("tool_info_list")]
        [XmlArrayItem("tool_info")]
        public List<ToolInfo> ToolInfoList { get; set; }
    }
}
