using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportIntelligentizeTaskCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportIntelligentizeTaskCreateModel : AopObject
    {
        /// <summary>
        /// 城市code
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 公交企业id
        /// </summary>
        [XmlElement("corp_id")]
        public string CorpId { get; set; }

        /// <summary>
        /// 扩展参数，双方约定
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 请求的唯一值标识
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 服务任务名
        /// </summary>
        [XmlElement("service_task_name")]
        public string ServiceTaskName { get; set; }

        /// <summary>
        /// 枚举字段声明要计算的指标类型
        /// </summary>
        [XmlElement("task_type")]
        public string TaskType { get; set; }
    }
}
