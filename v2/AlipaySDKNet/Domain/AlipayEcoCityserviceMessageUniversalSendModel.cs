using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoCityserviceMessageUniversalSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCityserviceMessageUniversalSendModel : AopObject
    {
        /// <summary>
        /// 模板中占位符模型列表
        /// </summary>
        [XmlArray("keyword_list")]
        [XmlArrayItem("universal_keyword")]
        public List<UniversalKeyword> KeywordList { get; set; }

        /// <summary>
        /// 生活号/小程序/内部小程序/内部应用appId
        /// </summary>
        [XmlElement("message_app_id")]
        public string MessageAppId { get; set; }

        /// <summary>
        /// 沟通平台模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 第三方消息Id
        /// </summary>
        [XmlElement("third_msg_id")]
        public string ThirdMsgId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
