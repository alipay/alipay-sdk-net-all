using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceBusinessAnalysisCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceBusinessAnalysisCreateModel : AopObject
    {
        /// <summary>
        /// 商圈ID
        /// </summary>
        [XmlElement("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// 0:商圈内 1:商圈内+商圈周边1km 3:商圈内+商圈周边3km 5:商圈内+商圈周边5km
        /// </summary>
        [XmlElement("mall_range")]
        public string MallRange { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 分析周期结束日期； 分析周期开始时间和分析周期结束时间之间的差距不能少于1天并且不能超过92天
        /// </summary>
        [XmlElement("schedule_end_date")]
        public string ScheduleEndDate { get; set; }

        /// <summary>
        /// 分析周期开始日期； 分析周期开始时间和分析周期结束时间之间的差距不能少于1天并且不能超过92天
        /// </summary>
        [XmlElement("schedule_start_date")]
        public string ScheduleStartDate { get; set; }

        /// <summary>
        /// 分析周期频次类型
        /// </summary>
        [XmlElement("schedule_type")]
        public string ScheduleType { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }
    }
}
