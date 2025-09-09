using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MultiStepTransferParticipant Data Structure.
    /// </summary>
    [Serializable]
    public class MultiStepTransferParticipant : AopObject
    {
        /// <summary>
        /// 代扣协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 参与方的唯一标识
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 唯一标识类型
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 还款协议号
        /// </summary>
        [XmlElement("rent_agreement_no")]
        public string RentAgreementNo { get; set; }
    }
}
