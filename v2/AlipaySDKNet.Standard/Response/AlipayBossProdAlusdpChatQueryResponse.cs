using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdAlusdpChatQueryResponse.
    /// </summary>
    public class AlipayBossProdAlusdpChatQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回数据
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 状态码对应的信息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 状态码
        /// </summary>
        [XmlElement("status_code")]
        public string StatusCode { get; set; }
    }
}
