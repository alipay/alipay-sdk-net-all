using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpAcceptanceQueryResponse.
    /// </summary>
    public class ZhimaCreditEpAcceptanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前的受理状态
        /// </summary>
        [XmlElement("acceptance_status")]
        public string AcceptanceStatus { get; set; }

        /// <summary>
        /// 统一社会信用代码或营业执照注册号，法人授权可返回
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业全称，法人授权可返回
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 法人有效证件号码，法人授权后可返回
        /// </summary>
        [XmlElement("legal_person_cert_no")]
        public string LegalPersonCertNo { get; set; }

        /// <summary>
        /// 企业法定代表人姓名，法人授权后可返回
        /// </summary>
        [XmlElement("legal_person_name")]
        public string LegalPersonName { get; set; }

        /// <summary>
        /// 用户联系方式，法人授权后可返回
        /// </summary>
        [XmlElement("tel_phone")]
        public string TelPhone { get; set; }

        /// <summary>
        /// 本次受理的支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
