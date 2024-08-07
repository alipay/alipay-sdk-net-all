using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryBotSessionCreateResponse.
    /// </summary>
    public class AlipayEbppIndustryBotSessionCreateResponse : AopResponse
    {
        /// <summary>
        /// 会话id。创建会话接口后返回的会话id，有效期10分钟。若10分钟内用户没有对话请求，会话id自动失效。
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
