using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportIntelligentizeChargescheduleCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportIntelligentizeChargescheduleCreateResponse : AopResponse
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 支付宝服务任务ID，保证全局唯一
        /// </summary>
        [XmlElement("service_task_id")]
        public string ServiceTaskId { get; set; }

        /// <summary>
        /// 服务任务类型
        /// </summary>
        [XmlElement("service_task_type")]
        public string ServiceTaskType { get; set; }
    }
}
