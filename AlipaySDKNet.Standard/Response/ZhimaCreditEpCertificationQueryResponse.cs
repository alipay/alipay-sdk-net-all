using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpCertificationQueryResponse.
    /// </summary>
    public class ZhimaCreditEpCertificationQueryResponse : AopResponse
    {
        /// <summary>
        /// 代理函有效访问地址，有效时间2分钟，接口返回后开始计时，auth_status为SUCCESS时返回，特定场景下返回
        /// </summary>
        [XmlElement("attorney_letter")]
        public string AttorneyLetter { get; set; }

        /// <summary>
        /// 授权状态，从用户授权开始计时，时间窗口3天 取值如下： SUCCESS，代表用户已授权 FAIL，代表用户未授权或授权失效
        /// </summary>
        [XmlElement("auth_status")]
        public string AuthStatus { get; set; }

        /// <summary>
        /// 营业执照有效访问地址，有效时间2分钟，接口返回后开始计时，字段auth_status为SUCCESS时返回，特定场景下返回
        /// </summary>
        [XmlElement("business_license")]
        public string BusinessLicense { get; set; }

        /// <summary>
        /// 代理人认证渠道，取值如下：LPIDCARD代表法人身份证认证渠道；EMAIL代表企业邮箱认证渠道
        /// </summary>
        [XmlElement("certify_channel")]
        public string CertifyChannel { get; set; }

        /// <summary>
        /// 认证完成时间
        /// </summary>
        [XmlElement("certify_end_date")]
        public string CertifyEndDate { get; set; }

        /// <summary>
        /// 认证失败原因列表，当certify_status=FAIL时返回
        /// </summary>
        [XmlArray("certify_fail_reasons")]
        [XmlArrayItem("string")]
        public List<string> CertifyFailReasons { get; set; }

        /// <summary>
        /// 认证模式，取值如下：ATTORNEY代表代理人；LEGAL_PERSON代表法定代表人
        /// </summary>
        [XmlElement("certify_mode")]
        public string CertifyMode { get; set; }

        /// <summary>
        /// 认证人有效证件后四位，当职业身份认证时返回
        /// </summary>
        [XmlElement("certify_person_card_no_postfix")]
        public string CertifyPersonCardNoPostfix { get; set; }

        /// <summary>
        /// 认证状态，取值如下： SUCCESS，代表成功 INIT，代表初始化 CERTIFYING，代表认证中 FAIL，代表失败
        /// </summary>
        [XmlElement("certify_status")]
        public string CertifyStatus { get; set; }

        /// <summary>
        /// 企业邮箱地址
        /// </summary>
        [XmlElement("email_address")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// 统一社会信用代码或营业执照注册号，字段auth_status为SUCCESS时返回
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业全称，字段auth_status为SUCCESS时返回
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 该企业是否有立信企业芝麻证 true:有;false:无
        /// </summary>
        [XmlElement("has_li_xin_certificate")]
        public bool HasLiXinCertificate { get; set; }

        /// <summary>
        /// 法人身份证反面有效访问定制，有效时间2分钟，接口返回后开始计时，auth_status为SUCCESS时返回，特定场景下返回
        /// </summary>
        [XmlElement("legal_person_id_card_back")]
        public string LegalPersonIdCardBack { get; set; }

        /// <summary>
        /// 法人身份证正面有效访问地址，有效时间2分钟，接口返回后开始计时，auth_status为SUCCESS时返回，特定场景下返回
        /// </summary>
        [XmlElement("legal_person_id_card_front")]
        public string LegalPersonIdCardFront { get; set; }

        /// <summary>
        /// 是否是立信企业 true:是;false:否
        /// </summary>
        [XmlElement("li_xin_ep")]
        public bool LiXinEp { get; set; }

        /// <summary>
        /// 个人用户姓名，字段auth_status为SUCCESS时返回
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
