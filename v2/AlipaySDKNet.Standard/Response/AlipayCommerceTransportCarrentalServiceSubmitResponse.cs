using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportCarrentalServiceSubmitResponse.
    /// </summary>
    public class AlipayCommerceTransportCarrentalServiceSubmitResponse : AopResponse
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 服务编码  需通过审核后才可使用
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }
    }
}
