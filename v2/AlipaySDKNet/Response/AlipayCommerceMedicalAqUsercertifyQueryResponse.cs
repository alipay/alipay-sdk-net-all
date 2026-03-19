using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalAqUsercertifyQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalAqUsercertifyQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 认证结果
        /// </summary>
        [XmlElement("certify_state")]
        public bool CertifyState { get; set; }

        /// <summary>
        /// 手机ha
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }
    }
}
