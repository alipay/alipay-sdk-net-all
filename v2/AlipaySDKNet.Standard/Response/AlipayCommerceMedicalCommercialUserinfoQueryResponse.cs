using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalCommercialUserinfoQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalCommercialUserinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 身份证
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
