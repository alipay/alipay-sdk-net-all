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

        /// <summary>
        /// 1. 收单机构调用API提交申请单时，可选择是否指定单个服务商范围。非收单机构无需填写此字段。 2. 此字段填写单个服务商pid信息：填写（即：单服务商提交认证方式），查询申请单返回的认证二维码qr_code和填写服务商对应，仅能认证填写服务商下的商户；不填写（即：全服务商提交认证方式），查询申请单返回的认证二维码qr_code和收单机构对应，可认证收单机构下全部商户。
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
