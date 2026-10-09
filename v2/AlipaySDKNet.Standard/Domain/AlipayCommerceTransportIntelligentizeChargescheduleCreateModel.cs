using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportIntelligentizeChargescheduleCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportIntelligentizeChargescheduleCreateModel : AopObject
    {
        /// <summary>
        /// 充电规划模式
        /// </summary>
        [XmlElement("charge_schedule_mode")]
        public string ChargeScheduleMode { get; set; }

        /// <summary>
        /// 城市代码，请按照支付宝标准传参
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 公交企业ID，由公交业主/公交ISV管理
        /// </summary>
        [XmlElement("corp_id")]
        public string CorpId { get; set; }

        /// <summary>
        /// 扩展参数，json格式，由双方约定取值
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 请求ID，唯一标识一次请求
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 服务任务名称，标记任务信息
        /// </summary>
        [XmlElement("service_task_name")]
        public string ServiceTaskName { get; set; }

        /// <summary>
        /// 排班计划列表
        /// </summary>
        [XmlArray("work_schedule_plan_list")]
        [XmlArrayItem("work_schedule_plan")]
        public List<WorkSchedulePlan> WorkSchedulePlanList { get; set; }
    }
}
