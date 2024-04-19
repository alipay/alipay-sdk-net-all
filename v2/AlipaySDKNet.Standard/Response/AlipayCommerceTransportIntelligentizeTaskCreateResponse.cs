using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportIntelligentizeTaskCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportIntelligentizeTaskCreateResponse : AopResponse
    {
        /// <summary>
        /// 传递扩展参数，双方约定
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 支付宝服务任务ID，保证全局唯一
        /// </summary>
        [XmlElement("service_task_id")]
        public string ServiceTaskId { get; set; }
    }
}
