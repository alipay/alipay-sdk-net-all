using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrescriptionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PrescriptionInfo : AopObject
    {
        /// <summary>
        /// 活动 ID
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 渠道，枚举: HM_WEIGHT_LOSS/HM_SLEEP
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 饮食方案，以markdown格式输出
        /// </summary>
        [XmlElement("diet_plan")]
        public string DietPlan { get; set; }

        /// <summary>
        /// 运动方案，以markdown格式输出
        /// </summary>
        [XmlElement("exercise_plan")]
        public string ExercisePlan { get; set; }

        /// <summary>
        /// 处方生成时间
        /// </summary>
        [XmlElement("prescription_generate_time")]
        public string PrescriptionGenerateTime { get; set; }

        /// <summary>
        /// 处方 ID
        /// </summary>
        [XmlElement("prescription_id")]
        public string PrescriptionId { get; set; }

        /// <summary>
        /// 方案名称
        /// </summary>
        [XmlElement("prescription_name")]
        public string PrescriptionName { get; set; }

        /// <summary>
        /// 心理方案，以markdown格式输出
        /// </summary>
        [XmlElement("psychology_plan")]
        public string PsychologyPlan { get; set; }

        /// <summary>
        /// 睡眠方案，以markdown格式输出
        /// </summary>
        [XmlElement("sleep_plan")]
        public string SleepPlan { get; set; }

        /// <summary>
        /// 处方状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
