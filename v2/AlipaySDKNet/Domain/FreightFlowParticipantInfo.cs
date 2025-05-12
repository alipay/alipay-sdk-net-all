using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FreightFlowParticipantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FreightFlowParticipantInfo : AopObject
    {
        /// <summary>
        /// 参与者类型(外部银行卡场景必选)  个人：INDIVIDUAL 企业：CORPORATION
        /// </summary>
        [XmlElement("participant_customer_type")]
        public string ParticipantCustomerType { get; set; }

        /// <summary>
        /// 网商活期：卡号  子户：子户卡号  外部银行卡：银行卡号  支付宝账户：支付宝登录号
        /// </summary>
        [XmlElement("participant_id")]
        public string ParticipantId { get; set; }

        /// <summary>
        /// 参与者联联行号(对公账户必传)
        /// </summary>
        [XmlElement("participant_inst_code")]
        public string ParticipantInstCode { get; set; }

        /// <summary>
        /// 参与者名称(户名)
        /// </summary>
        [XmlElement("participant_name")]
        public string ParticipantName { get; set; }

        /// <summary>
        /// 参与者类型  网商活期：CURRENT  子户：SUB_ACCOUNT  外部银行卡：EXTEND_BANK_CARD  支付宝账户：ALIPAY_ACCOUNT
        /// </summary>
        [XmlElement("participant_type")]
        public string ParticipantType { get; set; }
    }
}
