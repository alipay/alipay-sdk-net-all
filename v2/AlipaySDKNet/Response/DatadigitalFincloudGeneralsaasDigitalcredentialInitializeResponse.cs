using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasDigitalcredentialInitializeResponse.
    /// </summary>
    public class DatadigitalFincloudGeneralsaasDigitalcredentialInitializeResponse : AopResponse
    {
        /// <summary>
        /// query_status 为 SUCCESS 时返回的数字凭证单据号，请妥善保存，后续使用该值查询加密 VP。
        /// </summary>
        [XmlElement("certify_id")]
        public string CertifyId { get; set; }
    }
}
