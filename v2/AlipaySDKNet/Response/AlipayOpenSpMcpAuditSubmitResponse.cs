using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpMcpAuditSubmitResponse.
    /// </summary>
    public class AlipayOpenSpMcpAuditSubmitResponse : AopResponse
    {
        /// <summary>
        /// 提交审核结果
        /// </summary>
        [XmlElement("submit_result")]
        public string SubmitResult { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("tool_list")]
        [XmlArrayItem("string")]
        public List<string> ToolList { get; set; }
    }
}
