using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasOnepassWebInitializeResponse.
    /// </summary>
    public class DatadigitalFincloudGeneralsaasOnepassWebInitializeResponse : AopResponse
    {
        /// <summary>
        /// H5本机校验流水ID，请保留方便排查问题
        /// </summary>
        [XmlElement("certify_id")]
        public string CertifyId { get; set; }
    }
}
