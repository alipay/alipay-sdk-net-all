using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RepaymentPlanListPreview Data Structure.
    /// </summary>
    [Serializable]
    public class RepaymentPlanListPreview : AopObject
    {
        /// <summary>
        /// 还款计划项详情列表
        /// </summary>
        [XmlArray("repay_plan_detail_list")]
        [XmlArrayItem("repaymemt_plan_preview")]
        public List<RepaymemtPlanPreview> RepayPlanDetailList { get; set; }

        /// <summary>
        /// 总还款金额，单位：元
        /// </summary>
        [XmlElement("total_amt")]
        public string TotalAmt { get; set; }

        /// <summary>
        /// 总优惠利息金额，单位：元
        /// </summary>
        [XmlElement("total_deduct_int_amt")]
        public string TotalDeductIntAmt { get; set; }

        /// <summary>
        /// 总原始利息金额，单位：元
        /// </summary>
        [XmlElement("total_initial_int_amt")]
        public string TotalInitialIntAmt { get; set; }

        /// <summary>
        /// 总利息金额，单位：元； 字段间关系为 总利息金额 = 总原始利息金额 - 总优惠利息金额
        /// </summary>
        [XmlElement("total_int_amt")]
        public string TotalIntAmt { get; set; }

        /// <summary>
        /// 总还款本金，单位：元
        /// </summary>
        [XmlElement("total_prin_amt")]
        public string TotalPrinAmt { get; set; }

        /// <summary>
        /// 总担保费/服务费，单位：元
        /// </summary>
        [XmlElement("total_serv_amt")]
        public string TotalServAmt { get; set; }
    }
}
