using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotvspBusinessNotifyResponse.
    /// </summary>
    public class AlipayOpenIotvspBusinessNotifyResponse : AopResponse
    {
        /// <summary>
        /// 业务操作执行状态，不包含消息发送状态
        /// </summary>
        [XmlElement("biz_success")]
        public string BizSuccess { get; set; }

        /// <summary>
        /// 消息错误编码
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 消息发送状态，只有当biz_success为true时，才会发送消息。
        /// </summary>
        [XmlElement("msg_success")]
        public string MsgSuccess { get; set; }
    }
}
