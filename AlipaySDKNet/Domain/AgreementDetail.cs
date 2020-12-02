using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AgreementDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AgreementDetail : AopObject
    {
        /// <summary>
        /// 协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 协议状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
