using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeductionPlanResponse Data Structure.
    /// </summary>
    [Serializable]
    public class DeductionPlanResponse : AopObject
    {
        /// <summary>
        /// 卡ID
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 扣款金额
        /// </summary>
        [XmlElement("deduction_amount")]
        public string DeductionAmount { get; set; }

        /// <summary>
        /// 扣款计划状态
        /// </summary>
        [XmlElement("deduction_plan_status")]
        public string DeductionPlanStatus { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 原金额
        /// </summary>
        [XmlElement("original_amount")]
        public string OriginalAmount { get; set; }

        /// <summary>
        /// 期数
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 计划扣款时间
        /// </summary>
        [XmlElement("plan_deduction_time")]
        public string PlanDeductionTime { get; set; }

        /// <summary>
        /// 扣款计划ID
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }
    }
}
