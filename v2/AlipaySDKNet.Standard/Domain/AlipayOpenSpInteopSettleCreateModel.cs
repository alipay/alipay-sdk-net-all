using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpInteopSettleCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpInteopSettleCreateModel : AopObject
    {
        /// <summary>
        /// 受益人证照
        /// </summary>
        [XmlElement("benefit_info")]
        public BizOpenCertificateInfoForEntry BenefitInfo { get; set; }

        /// <summary>
        /// 业务开通主单号，用于一体化作业过程的申请单串联
        /// </summary>
        [XmlElement("inteop_order_no")]
        public string InteopOrderNo { get; set; }

        /// <summary>
        /// 法人证照
        /// </summary>
        [XmlElement("legal_info")]
        public BizOpenCertificateInfoForEntry LegalInfo { get; set; }

        /// <summary>
        /// 法人登录号
        /// </summary>
        [XmlElement("legal_person_logon_id")]
        public string LegalPersonLogonId { get; set; }

        /// <summary>
        /// 主体证照信息
        /// </summary>
        [XmlElement("license_info")]
        public BizOpenCommonMerchantLicenseInfo LicenseInfo { get; set; }

        /// <summary>
        /// 01普通企业  07个体工商户
        /// </summary>
        [XmlElement("merchant_type")]
        public string MerchantType { get; set; }
    }
}
