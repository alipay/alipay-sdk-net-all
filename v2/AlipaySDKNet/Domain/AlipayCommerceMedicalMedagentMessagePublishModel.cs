using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMedagentMessagePublishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMedagentMessagePublishModel : AopObject
    {
        /// <summary>
        /// 消息内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 消息参数
        /// </summary>
        [XmlElement("template_args")]
        public string TemplateArgs { get; set; }

        /// <summary>
        /// 消息模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
