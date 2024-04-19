using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdIfaatamMessagenotifySendResponse.
    /// </summary>
    public class AlipaySecurityProdIfaatamMessagenotifySendResponse : AopResponse
    {
        /// <summary>
        /// 接口调用返回状态码
        /// </summary>
        [XmlElement("return_code")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// 接口返回状态码描述
        /// </summary>
        [XmlElement("return_msg")]
        public string ReturnMsg { get; set; }

        /// <summary>
        /// 消息通知是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
