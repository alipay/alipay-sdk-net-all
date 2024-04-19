using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RepaymentParticipantExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RepaymentParticipantExtInfo : AopObject
    {
        /// <summary>
        /// 参与方关联的业务协议号，默认可选，特定场景提供，以业务接入文档为准。
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }
    }
}
