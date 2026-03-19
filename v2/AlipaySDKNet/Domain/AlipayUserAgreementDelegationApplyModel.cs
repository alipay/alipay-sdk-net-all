using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAgreementDelegationApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAgreementDelegationApplyModel : AopObject
    {
        /// <summary>
        /// 【描述】请按当前接入的方式进行填充，且输入值必须为文档中的参数取值范围。
        /// </summary>
        [XmlElement("access_params")]
        public AccessParams AccessParams { get; set; }

        /// <summary>
        /// 智能体id
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("conversation_history")]
        [XmlArrayItem("conversation")]
        public List<Conversation> ConversationHistory { get; set; }

        /// <summary>
        /// AI付代买委托信息
        /// </summary>
        [XmlElement("delegation_params")]
        public DelegationParams DelegationParams { get; set; }

        /// <summary>
        /// 商户签约号，代扣协议中标示用户的唯一签约号（确保在商户系统中唯一）。 格式规则：支持大写小写字母和数字，最长32位。 商户系统按需自定义传入，用于区分用户在同一产品码、同一签约场景下，签订的多份代扣协议。
        /// </summary>
        [XmlElement("external_agreement_no")]
        public string ExternalAgreementNo { get; set; }

        /// <summary>
        /// 个人签约产品码，商户和支付宝签约时确定，商户可咨询技术支持。
        /// </summary>
        [XmlElement("personal_product_code")]
        public string PersonalProductCode { get; set; }
    }
}
