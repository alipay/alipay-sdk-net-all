using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportIntelligentizeTimetableCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportIntelligentizeTimetableCreateResponse : AopResponse
    {
        /// <summary>
        /// 扩展信息，json格式，由双方约定取值
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 服务任务ID，用于查询服务任务状态和结果
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
