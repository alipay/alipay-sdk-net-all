using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpOpporFeedbackModifyResponse.
    /// </summary>
    public class AlipayOpenSpOpporFeedbackModifyResponse : AopResponse
    {
        /// <summary>
        /// 商机拓展结果反馈结果失败描述
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 商机拓展结果反馈结果是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
