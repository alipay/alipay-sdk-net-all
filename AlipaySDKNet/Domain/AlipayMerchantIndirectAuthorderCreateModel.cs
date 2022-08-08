using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantIndirectAuthorderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantIndirectAuthorderCreateModel : AopObject
    {
        /// <summary>
        /// 主体信息
        /// </summary>
        [XmlElement("auth_identity_info")]
        public AuthIdentityInfo AuthIdentityInfo { get; set; }

        /// <summary>
        /// 受益人信息。 如下情况时必填：主体类型为企业，且其法人/经营者不为最终受益所有人（即：legal_person_info内的is_benefit_person=false）；其他情况不填。
        /// </summary>
        [XmlElement("benefit_person_info")]
        public IndirectBenefitPersonInfo BenefitPersonInfo { get; set; }

        /// <summary>
        /// 联系人信息
        /// </summary>
        [XmlElement("contact_person_info")]
        public IndirectContactPersonInfo ContactPersonInfo { get; set; }

        /// <summary>
        /// 补充材料
        /// </summary>
        [XmlElement("extra_credentials")]
        public IndirectExtraCredentials ExtraCredentials { get; set; }

        /// <summary>
        /// 法人身份信息
        /// </summary>
        [XmlElement("legal_person_info")]
        public IndirectLegalPersonInfo LegalPersonInfo { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
