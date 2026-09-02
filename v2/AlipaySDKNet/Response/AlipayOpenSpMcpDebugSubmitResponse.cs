using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpMcpDebugSubmitResponse.
    /// </summary>
    public class AlipayOpenSpMcpDebugSubmitResponse : AopResponse
    {
        /// <summary>
        /// 调试结果详情
        /// </summary>
        [XmlElement("debug_result_info")]
        public string DebugResultInfo { get; set; }

        /// <summary>
        /// 调试调用是否成功 true-成功 false-失败
        /// </summary>
        [XmlElement("debug_success")]
        public bool DebugSuccess { get; set; }
    }
}
