using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeductionPlanDataSyncRequest Data Structure.
    /// </summary>
    [Serializable]
    public class DeductionPlanDataSyncRequest : AopObject
    {
        /// <summary>
        /// 课时数（电教馆教培特有）,单位个，表示有1个课时
        /// </summary>
        [XmlElement("class_hours")]
        public long ClassHours { get; set; }

        /// <summary>
        /// 扣款计划创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 实际扣款金额（单位元）
        /// </summary>
        [XmlElement("deduction_amount")]
        public string DeductionAmount { get; set; }

        /// <summary>
        /// 扣款计划id
        /// </summary>
        [XmlElement("deduction_plan_id")]
        public string DeductionPlanId { get; set; }

        /// <summary>
        /// 扣款计划状态
        /// </summary>
        [XmlElement("deduction_plan_status")]
        public string DeductionPlanStatus { get; set; }

        /// <summary>
        /// 原金额（单位元）
        /// </summary>
        [XmlElement("original_amount")]
        public string OriginalAmount { get; set; }

        /// <summary>
        /// 期数，具体数值，如1表示第1期
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 计划扣款日期
        /// </summary>
        [XmlElement("plan_deduction_time")]
        public string PlanDeductionTime { get; set; }

        /// <summary>
        /// 扣款计划更新时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }
    }
}
