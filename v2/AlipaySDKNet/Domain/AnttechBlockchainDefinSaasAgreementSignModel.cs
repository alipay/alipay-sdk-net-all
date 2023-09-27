using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinSaasAgreementSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinSaasAgreementSignModel : AopObject
    {
        /// <summary>
        /// 会员类型。E: 企业  I: 个人
        /// </summary>
        [XmlElement("entity_type")]
        public string EntityType { get; set; }

        /// <summary>
        /// entityType为I时为个人身份证号，entityType为E时为法人身份证号。entityType为I时必选
        /// </summary>
        [XmlElement("legal_person_cert_no")]
        public string LegalPersonCertNo { get; set; }

        /// <summary>
        /// entityType为I时表示个人姓名，entityType为E时表示法人姓名。entityType为I时必选
        /// </summary>
        [XmlElement("legal_person_name")]
        public string LegalPersonName { get; set; }

        /// <summary>
        /// 企业名称。entityType为E时必选
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 外部业务平台会员ID
        /// </summary>
        [XmlElement("out_member_id")]
        public ReferenceId OutMemberId { get; set; }

        /// <summary>
        /// 会员所属业务平台在智能科技的会员ID
        /// </summary>
        [XmlElement("platform_member_id")]
        public string PlatformMemberId { get; set; }

        /// <summary>
        /// 企业统一社会信用代码。entityType为E时必选
        /// </summary>
        [XmlElement("unified_social_credit_code")]
        public string UnifiedSocialCreditCode { get; set; }
    }
}
