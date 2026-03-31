using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotMarketingTaskCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotMarketingTaskCreateModel : AopObject
    {
        /// <summary>
        /// 投放设备bizTid列表,服务商所有的设备，取设备的bizTid 多个bizTid示例：["010100q0jl5X4o8LZQWAOUxu6GcrtPl4wR68wQerXVACt5EAaQISk4k","010100q0iZ5XP3eiSA25lhlyGq8dxPMOHe8Ae4s1BGptXegHN3fCQ1g"]
        /// </summary>
        [XmlArray("biz_tids")]
        [XmlArrayItem("string")]
        public List<string> BizTids { get; set; }

        /// <summary>
        /// 投放任务有效期结束时间戳
        /// </summary>
        [XmlElement("end_time")]
        public long EndTime { get; set; }

        /// <summary>
        /// 投放计划名称
        /// </summary>
        [XmlElement("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// 优先级
        /// </summary>
        [XmlElement("priority")]
        public long Priority { get; set; }

        /// <summary>
        /// 投放计划开始时间戳
        /// </summary>
        [XmlElement("start_time")]
        public long StartTime { get; set; }

        /// <summary>
        /// 投放模版id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
