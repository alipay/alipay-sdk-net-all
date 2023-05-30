using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdAshieldHardeningtaskSubmitResponse.
    /// </summary>
    public class AlipaySecurityProdAshieldHardeningtaskSubmitResponse : AopResponse
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
        public HardeningTaskResponse ResData { get; set; }
    }
}
