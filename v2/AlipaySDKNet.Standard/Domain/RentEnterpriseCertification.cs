using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentEnterpriseCertification Data Structure.
    /// </summary>
    [Serializable]
    public class RentEnterpriseCertification : AopObject
    {
        /// <summary>
        /// 代理人手机号
        /// </summary>
        [XmlElement("agent_person_cellphone")]
        public string AgentPersonCellphone { get; set; }

        /// <summary>
        /// 代理人身份证有效期
        /// </summary>
        [XmlElement("agent_person_cert_expire_date")]
        public string AgentPersonCertExpireDate { get; set; }

        /// <summary>
        /// 代理人身份证号
        /// </summary>
        [XmlElement("agent_person_cert_no")]
        public string AgentPersonCertNo { get; set; }

        /// <summary>
        /// 代理人身份证有效开始日期
        /// </summary>
        [XmlElement("agent_person_cert_start_date")]
        public string AgentPersonCertStartDate { get; set; }

        /// <summary>
        /// 代理人身份证国徽面照片地址
        /// </summary>
        [XmlElement("agent_person_emblem_cert_image_url")]
        public string AgentPersonEmblemCertImageUrl { get; set; }

        /// <summary>
        /// 代理人身份证人像面照片地址
        /// </summary>
        [XmlElement("agent_person_face_cert_image_url")]
        public string AgentPersonFaceCertImageUrl { get; set; }

        /// <summary>
        /// 代理人姓名
        /// </summary>
        [XmlElement("agent_person_name")]
        public string AgentPersonName { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("appid")]
        public string Appid { get; set; }

        /// <summary>
        /// 法人授权状态
        /// </summary>
        [XmlElement("auth_status")]
        public string AuthStatus { get; set; }

        /// <summary>
        /// 企业认证结果
        /// </summary>
        [XmlElement("certification_result")]
        public string CertificationResult { get; set; }

        /// <summary>
        /// 认证类型
        /// </summary>
        [XmlElement("certification_type")]
        public string CertificationType { get; set; }

        /// <summary>
        /// 企业地址
        /// </summary>
        [XmlElement("enterprise_address")]
        public string EnterpriseAddress { get; set; }

        /// <summary>
        /// 营业执照有效时间（年-月-日）
        /// </summary>
        [XmlElement("enterprise_license_expire_date")]
        public string EnterpriseLicenseExpireDate { get; set; }

        /// <summary>
        /// 营业执照图片地址
        /// </summary>
        [XmlElement("enterprise_license_image_url")]
        public string EnterpriseLicenseImageUrl { get; set; }

        /// <summary>
        /// 营业执照开始日期（年-月-日）
        /// </summary>
        [XmlElement("enterprise_license_start_date")]
        public string EnterpriseLicenseStartDate { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("enterprise_name")]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// 企业上一次认证成功时的日期时间
        /// </summary>
        [XmlElement("gmt_authentication_success")]
        public string GmtAuthenticationSuccess { get; set; }

        /// <summary>
        /// 法人手机号
        /// </summary>
        [XmlElement("legal_person_cellphone")]
        public string LegalPersonCellphone { get; set; }

        /// <summary>
        /// 法人身份证有效期，到期日期（年-月-日）
        /// </summary>
        [XmlElement("legal_person_cert_expire_date")]
        public string LegalPersonCertExpireDate { get; set; }

        /// <summary>
        /// 法人身份证号码
        /// </summary>
        [XmlElement("legal_person_cert_no")]
        public string LegalPersonCertNo { get; set; }

        /// <summary>
        /// 法人身份证有效期开始日期（年-月-日）
        /// </summary>
        [XmlElement("legal_person_cert_start_date")]
        public string LegalPersonCertStartDate { get; set; }

        /// <summary>
        /// 法人身份证国徽面图片
        /// </summary>
        [XmlElement("legal_person_emblem_cert_image_url")]
        public string LegalPersonEmblemCertImageUrl { get; set; }

        /// <summary>
        /// 法人证件照人像面
        /// </summary>
        [XmlElement("legal_person_face_cert_image_url")]
        public string LegalPersonFaceCertImageUrl { get; set; }

        /// <summary>
        /// 法人姓名
        /// </summary>
        [XmlElement("legal_person_name")]
        public string LegalPersonName { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_open_id")]
        public string PartnerOpenId { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("unified_social_credit_code")]
        public string UnifiedSocialCreditCode { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
