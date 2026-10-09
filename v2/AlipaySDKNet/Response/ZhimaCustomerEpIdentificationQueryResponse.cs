using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerEpIdentificationQueryResponse.
    /// </summary>
    public class ZhimaCustomerEpIdentificationQueryResponse : AopResponse
    {
        /// <summary>
        /// 认证的企业证件号。
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 认证的企业名。
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 认证不通过的错误码。
        /// </summary>
        [XmlElement("failed_code")]
        public string FailedCode { get; set; }

        /// <summary>
        /// 认证是否通过，通过为true，不通过为false。
        /// </summary>
        [XmlElement("passed")]
        public string Passed { get; set; }
    }
}
