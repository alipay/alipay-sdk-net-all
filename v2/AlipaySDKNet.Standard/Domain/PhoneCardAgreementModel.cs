using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PhoneCardAgreementModel Data Structure.
    /// </summary>
    [Serializable]
    public class PhoneCardAgreementModel : AopObject
    {
        /// <summary>
        /// html文本，用于前端页面展示
        /// </summary>
        [XmlElement("agreement_content")]
        public string AgreementContent { get; set; }

        /// <summary>
        /// 协议id
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 协议标题
        /// </summary>
        [XmlElement("agreement_title")]
        public string AgreementTitle { get; set; }

        /// <summary>
        /// 协议类型
        /// </summary>
        [XmlElement("agreement_type")]
        public string AgreementType { get; set; }
    }
}
