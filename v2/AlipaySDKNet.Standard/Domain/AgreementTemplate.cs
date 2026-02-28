using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AgreementTemplate Data Structure.
    /// </summary>
    [Serializable]
    public class AgreementTemplate : AopObject
    {
        /// <summary>
        /// 协议名称
        /// </summary>
        [XmlElement("agreement_name")]
        public string AgreementName { get; set; }

        /// <summary>
        /// 协议模版id
        /// </summary>
        [XmlElement("agreement_template_id")]
        public string AgreementTemplateId { get; set; }

        /// <summary>
        /// 协议链接
        /// </summary>
        [XmlElement("agreement_url")]
        public string AgreementUrl { get; set; }
    }
}
