using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIndustryServiceSubmitResponse.
    /// </summary>
    public class AlipayCommerceIndustryServiceSubmitResponse : AopResponse
    {
        /// <summary>
        /// 成功请求ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 服务编码 需通过审核后才可使用
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }
    }
}
