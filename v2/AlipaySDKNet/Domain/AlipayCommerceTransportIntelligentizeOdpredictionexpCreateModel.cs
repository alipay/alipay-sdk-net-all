using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportIntelligentizeOdpredictionexpCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportIntelligentizeOdpredictionexpCreateModel : AopObject
    {
        /// <summary>
        /// 城市码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 公交地铁企业id
        /// </summary>
        [XmlElement("corp_id")]
        public string CorpId { get; set; }

        /// <summary>
        /// 服务任务扩展参数
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 客流预测任务响应返回的任务id作为入参创建客流预测体验变化任务
        /// </summary>
        [XmlElement("od_prediction_service_task_id")]
        public string OdPredictionServiceTaskId { get; set; }

        /// <summary>
        /// 请求ID，唯一标识一次请求，由调用方自行确保唯一性
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 客流预测体验变化任务名称
        /// </summary>
        [XmlElement("service_task_name")]
        public string ServiceTaskName { get; set; }
    }
}
