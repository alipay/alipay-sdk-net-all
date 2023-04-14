using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasFaceCertifyVerifyResponse.
    /// </summary>
    public class DatadigitalFincloudGeneralsaasFaceCertifyVerifyResponse : AopResponse
    {
        /// <summary>
        /// 返回用于唤起刷脸页面的url
        /// </summary>
        [XmlElement("certify_url")]
        public string CertifyUrl { get; set; }
    }
}
