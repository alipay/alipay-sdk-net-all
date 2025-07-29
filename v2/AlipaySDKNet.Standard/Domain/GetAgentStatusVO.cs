using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GetAgentStatusVO Data Structure.
    /// </summary>
    [Serializable]
    public class GetAgentStatusVO : AopObject
    {
        /// <summary>
        /// 该医生开通或者升级了ai医生：true,没有开通或者升级：false
        /// </summary>
        [XmlElement("ai_assistant_opened_status")]
        public bool AiAssistantOpenedStatus { get; set; }

        /// <summary>
        /// 医生id，开启了ai医生时必填
        /// </summary>
        [XmlElement("avatar_id")]
        public string AvatarId { get; set; }

        /// <summary>
        /// 合法状态，true(通过好大夫的医生Id在灵知平台查到了医生信息)为合法，false为不合法
        /// </summary>
        [XmlElement("legal_status")]
        public bool LegalStatus { get; set; }

        /// <summary>
        /// ai医生跳转链接，aiAssistantOpened为true时返回跳转链接
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
