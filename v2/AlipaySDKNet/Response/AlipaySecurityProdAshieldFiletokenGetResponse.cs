using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdAshieldFiletokenGetResponse.
    /// </summary>
    public class AlipaySecurityProdAshieldFiletokenGetResponse : AopResponse
    {
        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 返回的具体对象
        /// </summary>
        [XmlElement("res_data")]
        public FileTokenForUpload ResData { get; set; }
    }
}
