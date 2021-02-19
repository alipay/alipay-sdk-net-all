using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicMessageSingleSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicMessageSingleSendModel : AopObject
    {
        /// <summary>
        /// 消息模板相关参数，其中包括templateId模板ID和context模板上下文
        /// </summary>
        [XmlElement("template")]
        public Template Template { get; set; }

        /// <summary>
        /// 消息接收用户的支付宝用户id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。
        /// </summary>
        [XmlElement("to_user_id")]
        public string ToUserId { get; set; }
    }
}
