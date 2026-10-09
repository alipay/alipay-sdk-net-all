using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AgreementTextInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AgreementTextInfo : AopObject
    {
        /// <summary>
        /// 协议文本名称
        /// </summary>
        [XmlElement("agreement_text_title")]
        public string AgreementTextTitle { get; set; }

        /// <summary>
        /// 协议文本对应的url
        /// </summary>
        [XmlElement("agreement_text_url")]
        public string AgreementTextUrl { get; set; }
    }
}
