using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupBudgetSummaryDTO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupBudgetSummaryDTO : AopObject
    {
        /// <summary>
        /// 预算受益部门编码
        /// </summary>
        [XmlElement("benefiting_dept")]
        public string BenefitingDept { get; set; }

        /// <summary>
        /// 预算受益部门
        /// </summary>
        [XmlElement("benefiting_dept_name")]
        public string BenefitingDeptName { get; set; }

        /// <summary>
        /// bg编码
        /// </summary>
        [XmlElement("bg_code")]
        public string BgCode { get; set; }

        /// <summary>
        /// bu编码
        /// </summary>
        [XmlElement("bu_code")]
        public string BuCode { get; set; }

        /// <summary>
        /// 预算科目编码
        /// </summary>
        [XmlElement("budget_account")]
        public string BudgetAccount { get; set; }

        /// <summary>
        /// 预算科目名称
        /// </summary>
        [XmlElement("budget_account_name")]
        public string BudgetAccountName { get; set; }

        /// <summary>
        /// 集团预算年份
        /// </summary>
        [XmlElement("budget_fy")]
        public string BudgetFy { get; set; }

        /// <summary>
        /// 集团预算编码，由GB开头
        /// </summary>
        [XmlElement("group_budget_code")]
        public string GroupBudgetCode { get; set; }

        /// <summary>
        /// 预算编制部门编码
        /// </summary>
        [XmlElement("making_dept")]
        public string MakingDept { get; set; }

        /// <summary>
        /// 预算编制部门
        /// </summary>
        [XmlElement("making_dept_name")]
        public string MakingDeptName { get; set; }

        /// <summary>
        /// 剩余可用金额(单位：元)
        /// </summary>
        [XmlElement("remain_amount")]
        public string RemainAmount { get; set; }

        /// <summary>
        /// 剩余可用金额币种
        /// </summary>
        [XmlElement("remain_amount_currency")]
        public string RemainAmountCurrency { get; set; }
    }
}
