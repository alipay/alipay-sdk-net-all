using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAgreementDelegationSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAgreementDelegationSignModel : AopObject
    {
        /// <summary>
        /// AI支付协议号
        /// </summary>
        [XmlElement("ai_pay_agreement_no")]
        public string AiPayAgreementNo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("conversation_history")]
        [XmlArrayItem("conversation")]
        public List<Conversation> ConversationHistory { get; set; }

        /// <summary>
        /// 对委托任务做总结描述
        /// </summary>
        [XmlElement("delegation_desc")]
        public string DelegationDesc { get; set; }

        /// <summary>
        /// 委托业务场景
        /// </summary>
        [XmlElement("delegation_scene")]
        public string DelegationScene { get; set; }

        /// <summary>
        /// 委托任务标签
        /// </summary>
        [XmlElement("delegation_tag")]
        public string DelegationTag { get; set; }

        /// <summary>
        /// 外部委托号
        /// </summary>
        [XmlElement("external_delegation_id")]
        public string ExternalDelegationId { get; set; }

        /// <summary>
        /// 免密协议号
        /// </summary>
        [XmlElement("no_pwd_agreement_no")]
        public string NoPwdAgreementNo { get; set; }
    }
}
