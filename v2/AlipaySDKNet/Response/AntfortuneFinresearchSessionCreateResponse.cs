using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneFinresearchSessionCreateResponse.
    /// </summary>
    public class AntfortuneFinresearchSessionCreateResponse : AopResponse
    {
        /// <summary>
        /// 新建会话成功之后返回的会话id，后续可以使用这个id进行提问题
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
