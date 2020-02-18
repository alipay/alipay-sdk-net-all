using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsAutoUserMsgSendResponse.
    /// </summary>
    public class AlipayInsAutoUserMsgSendResponse : AopResponse
    {
        /// <summary>
        /// 描述是否可以重试
        /// </summary>
        [XmlElement("can_retry")]
        public bool CanRetry { get; set; }
    }
}
