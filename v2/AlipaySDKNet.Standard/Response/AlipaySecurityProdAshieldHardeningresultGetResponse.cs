using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdAshieldHardeningresultGetResponse.
    /// </summary>
    public class AlipaySecurityProdAshieldHardeningresultGetResponse : AopResponse
    {
        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 加固产物的下载链接
        /// </summary>
        [XmlElement("res_data")]
        public string ResData { get; set; }
    }
}
