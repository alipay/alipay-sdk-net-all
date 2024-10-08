using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndustryWithholdPlanDTO Data Structure.
    /// </summary>
    [Serializable]
    public class IndustryWithholdPlanDTO : AopObject
    {
        /// <summary>
        /// 某一笔交易中的已扣款金额，单位为分
        /// </summary>
        [XmlElement("deducted_amount")]
        public long DeductedAmount { get; set; }

        /// <summary>
        /// 代扣计划期号
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 当前期号下的已还款金额，单位为分
        /// </summary>
        [XmlElement("repayed_amount")]
        public long RepayedAmount { get; set; }

        /// <summary>
        /// 当前期号的代扣计划状态。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 待扣款金额，单位为分
        /// </summary>
        [XmlElement("to_deduct_amount")]
        public long ToDeductAmount { get; set; }

        /// <summary>
        /// 当前期号下的总代还金额，单位为分
        /// </summary>
        [XmlElement("total_to_repay_amount")]
        public long TotalToRepayAmount { get; set; }

        /// <summary>
        /// 当前期号代扣执行日期
        /// </summary>
        [XmlElement("withhold_date")]
        public string WithholdDate { get; set; }
    }
}
