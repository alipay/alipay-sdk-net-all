using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunCallcontainerSessionApplyResponse.
    /// </summary>
    public class AlipayCloudCloudrunCallcontainerSessionApplyResponse : AopResponse
    {
        /// <summary>
        /// 单次会话ID，后续都需要传递，如果超时了需要新申请
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
