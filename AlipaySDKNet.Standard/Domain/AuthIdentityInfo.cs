using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AuthIdentityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AuthIdentityInfo : AopObject
    {
        /// <summary>
        /// 证件信息，主体类型为企业/个体户/政府机关/事业单位/社会组织时，必填
        /// </summary>
        [XmlElement("certificate_info")]
        public IndirectCertificateInfo CertificateInfo { get; set; }

        /// <summary>
        /// 主体类型为企业/个体户/政府机关/事业单位/社会组织时，必填； 证照类型：营业执照(BUSINESS_CERT)/登记证书(REGISTER_CERT) 主体为政府机关/事业单位/社会组织时，填登记证书； 主体类型为企业/个体户时，填营业执照；
        /// </summary>
        [XmlElement("certificate_type")]
        public string CertificateType { get; set; }

        /// <summary>
        /// 单位证明函照片（使用图片上传接口）主体类型为政府机关/事业单位时，单位证明函照片必填
        /// </summary>
        [XmlElement("employer_letter_img")]
        public string EmployerLetterImg { get; set; }

        /// <summary>
        /// 金融机构信息，当主体为金融机构时，必填
        /// </summary>
        [XmlElement("financial_org_info")]
        public IndirectFinancialOrgInfo FinancialOrgInfo { get; set; }

        /// <summary>
        /// 主体类型，枚举定义：企业(ENTERPRISE)、个体工商户(IND_BIZ)、事业单位(INST)、党政机关(GOV)、社会组织(ORG)、小微商户(MSE)
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 是否金融机构
        /// </summary>
        [XmlElement("is_financial_org")]
        public bool IsFinancialOrg { get; set; }

        /// <summary>
        /// 经营许可证列表，填写特殊行业的经营许可证信息，一个主体最多5个行业
        /// </summary>
        [XmlArray("qualification_info_list")]
        [XmlArrayItem("indirect_qualification_info")]
        public List<IndirectQualificationInfo> QualificationInfoList { get; set; }

        /// <summary>
        /// 辅助证明材料,主体类型为小微商户时，辅助证明材料信息必填
        /// </summary>
        [XmlElement("support_credentials")]
        public IndirectSupportCredentials SupportCredentials { get; set; }
    }
}
