using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundMbpcardPurchaseSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundMbpcardPurchaseSignModel : AopObject
    {
        /// <summary>
        /// 算法名称，加密使用
        /// </summary>
        [XmlElement("algorithm_name")]
        public string AlgorithmName { get; set; }

        /// <summary>
        /// 支付宝账号
        /// </summary>
        [XmlElement("alipay_identity_id")]
        public string AlipayIdentityId { get; set; }

        /// <summary>
        /// 支付宝账号类型 ALIPAY_LOGON_ID：登录号 ALIPAY_USER_ID：会员号
        /// </summary>
        [XmlElement("alipay_identity_type")]
        public string AlipayIdentityType { get; set; }

        /// <summary>
        /// 证件正面图片存储标识
        /// </summary>
        [XmlElement("cert_image")]
        public string CertImage { get; set; }

        /// <summary>
        /// 证件背面图片存储标识
        /// </summary>
        [XmlElement("cert_image_back")]
        public string CertImageBack { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 营业执照: 201 事业单位法人证书: 218 民办非企业登记证书: 204 社会团体法人登记证书: 206 党政机关批准设立文件/行政执法主体资格证: 219 个人身份证: 100
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 密钥类型：RSA，RSA2
        /// </summary>
        [XmlElement("cipher_type")]
        public string CipherType { get; set; }

        /// <summary>
        /// 联系人列表，支持多个
        /// </summary>
        [XmlArray("contact_infos")]
        [XmlArrayItem("contact_user_info")]
        public List<ContactUserInfo> ContactInfos { get; set; }

        /// <summary>
        /// 证件背面图片存储标识
        /// </summary>
        [XmlElement("legal_cert_back_image")]
        public string LegalCertBackImage { get; set; }

        /// <summary>
        /// 证件正面图片存储标识
        /// </summary>
        [XmlElement("legal_cert_front_image")]
        public string LegalCertFrontImage { get; set; }

        /// <summary>
        /// 法人身份证号
        /// </summary>
        [XmlElement("legal_cert_no")]
        public string LegalCertNo { get; set; }

        /// <summary>
        /// 法人姓名
        /// </summary>
        [XmlElement("legal_name")]
        public string LegalName { get; set; }

        /// <summary>
        /// 法人手机号或座机
        /// </summary>
        [XmlElement("legal_phone")]
        public string LegalPhone { get; set; }

        /// <summary>
        /// 支付宝开放平台账号
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 企业加密公钥；服务商购卡适用； 密钥类型和密钥必须同时存在
        /// </summary>
        [XmlElement("public_rsa_key")]
        public string PublicRsaKey { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
