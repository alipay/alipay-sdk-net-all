using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceTpaeventSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsuranceTpaeventSyncResponse : AopResponse
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
        /// 被保人证件号
        /// </summary>
        [XmlElement("insured_cert_no")]
        public string InsuredCertNo { get; set; }

        /// <summary>
        /// 被保人证件类型
        /// </summary>
        [XmlElement("insured_cert_type")]
        public string InsuredCertType { get; set; }

        /// <summary>
        /// 被保人姓名
        /// </summary>
        [XmlElement("insured_name")]
        public string InsuredName { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }
    }
}
