using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditPerformancePlanInfoOpen Data Structure.
    /// </summary>
    [Serializable]
    public class CreditPerformancePlanInfoOpen : AopObject
    {
        /// <summary>
        /// 计划详情列表
        /// </summary>
        [XmlArray("plan_details")]
        [XmlArrayItem("credit_performance_plan_detail_open")]
        public List<CreditPerformancePlanDetailOpen> PlanDetails { get; set; }

        /// <summary>
        /// 分期总数
        /// </summary>
        [XmlElement("times")]
        public string Times { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        [XmlElement("total_actual_amount")]
        public string TotalActualAmount { get; set; }
    }
}
