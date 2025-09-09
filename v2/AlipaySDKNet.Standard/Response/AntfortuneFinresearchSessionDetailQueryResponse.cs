using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneFinresearchSessionDetailQueryResponse.
    /// </summary>
    public class AntfortuneFinresearchSessionDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 会话列表
        /// </summary>
        [XmlElement("message_list")]
        public FinMessageDetail MessageList { get; set; }

        /// <summary>
        /// 会话详情
        /// </summary>
        [XmlElement("session_detail")]
        public FinSessionDetail SessionDetail { get; set; }
    }
}
