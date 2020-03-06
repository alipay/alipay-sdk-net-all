using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScheduleListItem Data Structure.
    /// </summary>
    [Serializable]
    public class ScheduleListItem : AopObject
    {
        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 任务状态枚举。 0：准备， 1：运行中  2：已完成  3： 失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 任务类型。枚举，参考任务类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
