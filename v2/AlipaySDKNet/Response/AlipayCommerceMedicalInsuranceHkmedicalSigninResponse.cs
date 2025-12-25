using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceHkmedicalSigninResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsuranceHkmedicalSigninResponse : AopResponse
    {
        /// <summary>
        /// 用户证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 用户证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 保司类型
        /// </summary>
        [XmlElement("company_type")]
        public string CompanyType { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 支付宝用户的唯一 ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 支付宝用户的唯一 ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
