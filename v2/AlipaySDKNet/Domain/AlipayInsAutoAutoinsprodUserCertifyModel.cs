using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodUserCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsAutoAutoinsprodUserCertifyModel : AopObject
    {
        /// <summary>
        /// 代理人姓名
        /// </summary>
        [XmlElement("agent_id_card_name")]
        public string AgentIdCardName { get; set; }

        /// <summary>
        /// 代理人身份证号
        /// </summary>
        [XmlElement("agent_id_card_no")]
        public string AgentIdCardNo { get; set; }

        /// <summary>
        /// 代理人用户唯一标识openId
        /// </summary>
        [XmlElement("agent_open_id")]
        public string AgentOpenId { get; set; }

        /// <summary>
        /// 代理人用户唯一标识
        /// </summary>
        [XmlElement("agent_user_id")]
        public string AgentUserId { get; set; }

        /// <summary>
        /// 授权代理人姓名
        /// </summary>
        [XmlElement("auth_cert_name")]
        public string AuthCertName { get; set; }

        /// <summary>
        /// 授权证件号码
        /// </summary>
        [XmlElement("auth_cert_no")]
        public string AuthCertNo { get; set; }
    }
}
