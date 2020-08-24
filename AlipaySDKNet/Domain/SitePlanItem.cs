using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SitePlanItem Data Structure.
    /// </summary>
    [Serializable]
    public class SitePlanItem : AopObject
    {
        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }
    }
}
