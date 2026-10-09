using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdAshieldHardeninglogGetResponse.
    /// </summary>
    public class AlipaySecurityProdAshieldHardeninglogGetResponse : AopResponse
    {
        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 加固日志的下载链接
        /// </summary>
        [XmlElement("res_data")]
        public string ResData { get; set; }
    }
}
