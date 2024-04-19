using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RelatedParties Data Structure.
    /// </summary>
    [Serializable]
    public class RelatedParties : AopObject
    {
        /// <summary>
        /// 相关方证件号码，请按实际证件号码填写
        /// </summary>
        [XmlElement("related_party_cert_no")]
        public string RelatedPartyCertNo { get; set; }

        /// <summary>
        /// 相关方证件类型，请结合实际按枚举值填写
        /// </summary>
        [XmlElement("related_party_cert_type")]
        public string RelatedPartyCertType { get; set; }

        /// <summary>
        /// 相关方名称，请按实际资产相关方名称填写
        /// </summary>
        [XmlElement("related_party_name")]
        public string RelatedPartyName { get; set; }

        /// <summary>
        /// 相关方类型，请结合资产相关方实际，按照枚举值提供
        /// </summary>
        [XmlElement("related_party_type")]
        public string RelatedPartyType { get; set; }
    }
}
