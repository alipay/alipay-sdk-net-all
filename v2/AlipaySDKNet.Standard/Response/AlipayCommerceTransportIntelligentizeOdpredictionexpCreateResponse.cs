using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportIntelligentizeOdpredictionexpCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportIntelligentizeOdpredictionexpCreateResponse : AopResponse
    {
        /// <summary>
        /// 客流预测体验变化扩展信息响应
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 服务任务id，具体服务任务下唯一
        /// </summary>
        [XmlElement("service_task_id")]
        public string ServiceTaskId { get; set; }

        /// <summary>
        /// 服务任务类型，当前服务任务类型对应于OD_PREDICTION_EXPERIENCE
        /// </summary>
        [XmlElement("service_task_type")]
        public string ServiceTaskType { get; set; }
    }
}
