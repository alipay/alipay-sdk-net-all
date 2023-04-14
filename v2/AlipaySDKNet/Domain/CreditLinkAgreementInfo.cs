using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditLinkAgreementInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CreditLinkAgreementInfo : AopObject
    {
        /// <summary>
        /// 协议路径
        /// </summary>
        [XmlElement("agreement_path")]
        public string AgreementPath { get; set; }

        /// <summary>
        /// 协议类型
        /// </summary>
        [XmlElement("agreement_type")]
        public string AgreementType { get; set; }

        /// <summary>
        /// 是否盖章
        /// </summary>
        [XmlElement("seal_flag")]
        public bool SealFlag { get; set; }
    }
}
