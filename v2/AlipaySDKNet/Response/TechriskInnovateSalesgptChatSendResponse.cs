using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// TechriskInnovateSalesgptChatSendResponse.
    /// </summary>
    public class TechriskInnovateSalesgptChatSendResponse : AopResponse
    {
        /// <summary>
        /// 对话结果，需要接入方优化使用
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
