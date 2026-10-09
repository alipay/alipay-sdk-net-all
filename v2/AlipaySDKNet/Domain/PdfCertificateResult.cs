using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PdfCertificateResult Data Structure.
    /// </summary>
    [Serializable]
    public class PdfCertificateResult : AopObject
    {
        /// <summary>
        /// 颁发者
        /// </summary>
        [XmlElement("ca_issuer")]
        public CaSdnDTO CaIssuer { get; set; }

        /// <summary>
        /// 主题
        /// </summary>
        [XmlElement("ca_subject")]
        public CaSdnDTO CaSubject { get; set; }

        /// <summary>
        /// CA_ISSUER_MATCH_FAILED("CT271","颁发者无法匹配：系统无法校验证书颁发者身份"),      SIGNATURE_CHECK_CA_FAILED("CT272","没有CA：未检测到签名人的数字证书"),      VERIFY_SIGNATURE_CHECK_CA_FAILED("CT273","文档已被更改：该文档在签名/盖章过程中已被更改"),      CHECK_SIGNATURE_DATE_FAILED("CT274","证书不在有效期内"),
        /// </summary>
        [XmlArray("failed_reason")]
        [XmlArrayItem("common_list_d_t_o")]
        public List<CommonListDTO> FailedReason { get; set; }

        /// <summary>
        /// 证书颁发者
        /// </summary>
        [XmlElement("issuer_dn")]
        public string IssuerDn { get; set; }

        /// <summary>
        /// 签名结束时间
        /// </summary>
        [XmlElement("not_after")]
        public string NotAfter { get; set; }

        /// <summary>
        /// 签名有效开始时间
        /// </summary>
        [XmlElement("not_before")]
        public string NotBefore { get; set; }

        /// <summary>
        /// 证书格式。为签名中提取的格式，不可枚举
        /// </summary>
        [XmlElement("public_key_format")]
        public string PublicKeyFormat { get; set; }

        /// <summary>
        /// 序列号
        /// </summary>
        [XmlElement("serial_number")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// 签名版本。为签名中提取的字段，不可枚举
        /// </summary>
        [XmlElement("sign_cert_version")]
        public string SignCertVersion { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [XmlElement("sign_date")]
        public string SignDate { get; set; }

        /// <summary>
        /// 签名名称
        /// </summary>
        [XmlElement("sign_name")]
        public string SignName { get; set; }

        /// <summary>
        /// 证书主题               数字证书中主题(_subject)中字段的含义                             公用名称 (_common _name) 简称：_c_n 字段，对于 _s_s_l 证书，一般为网站域名；而对于代码签名证书则为申请单位名称；而对于客户端证书则为证书申请者的姓名；               单位名称 (_organization _name) ：简称：_o 字段，对于 _s_s_l 证书，一般为网站域名；而对于代码签名证书则为申请单位名称；而对于客户端单位证书则为证书申请者所在单位名称；               证书申请单位所在地：               所在城市 (_locality) 简称：_l 字段               所在省份 (_state/_provice) 简称：_s 字段               所在国家 (_country) 简称：_c 字段，只能是国家字母缩写，如中国：_c_n               其他一些字段：               电子邮件 (_email) 简称：_e 字段               多个姓名字段 简称：_g 字段               介绍：_description 字段               电话号码：_phone 字段，格式要求 + 国家区号 城市区号 电话号码，如： +86 732 88888888               地址：_s_t_r_e_e_t  字段               邮政编码：_postal_code 字段               显示其他内容 简称：_o_u 字段
        /// </summary>
        [XmlElement("subject_dn")]
        public string SubjectDn { get; set; }

        /// <summary>
        /// 签名时间戳
        /// </summary>
        [XmlElement("time_stamp_date")]
        public string TimeStampDate { get; set; }

        /// <summary>
        /// 电子章验证结果
        /// </summary>
        [XmlElement("verified")]
        public bool Verified { get; set; }

        /// <summary>
        /// 验证所有签名是否被篡改
        /// </summary>
        [XmlElement("verify_signature")]
        public bool VerifySignature { get; set; }

        /// <summary>
        /// 验证签名时间戳
        /// </summary>
        [XmlElement("verify_timestamp_imprint")]
        public bool VerifyTimestampImprint { get; set; }
    }
}
