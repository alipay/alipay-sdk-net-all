using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportIntelligentizeOdpredictionCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportIntelligentizeOdpredictionCreateResponse : AopResponse
    {
        /// <summary>
        /// 找不到当前任务对应线路站点数据
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 服务任务id，在具体任务类型下唯一
        /// </summary>
        [XmlElement("service_task_id")]
        public string ServiceTaskId { get; set; }

        /// <summary>
        /// 服务任务类型，当前任务对应于OD_PREDICTION
        /// </summary>
        [XmlElement("service_task_type")]
        public string ServiceTaskType { get; set; }
    }
}
