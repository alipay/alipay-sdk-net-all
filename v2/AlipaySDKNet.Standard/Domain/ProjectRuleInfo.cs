using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProjectRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ProjectRuleInfo : AopObject
    {
        /// <summary>
        /// 有效期截止
        /// </summary>
        [XmlElement("effective_end_date")]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 有效期起始
        /// </summary>
        [XmlElement("effective_start_date")]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 切换open_id前请使用此字段：员工uid列表
        /// </summary>
        [XmlArray("employee_list")]
        [XmlArrayItem("string")]
        public List<string> EmployeeList { get; set; }

        /// <summary>
        /// 切换open_id后请使用此字段：员工open_id列表
        /// </summary>
        [XmlArray("employee_open_id_list")]
        [XmlArrayItem("string")]
        public List<string> EmployeeOpenIdList { get; set; }

        /// <summary>
        /// 规则组列表
        /// </summary>
        [XmlArray("expense_ctrl_rule_info_group_list")]
        [XmlArrayItem("expense_ctr_rule_group_info")]
        public List<ExpenseCtrRuleGroupInfo> ExpenseCtrlRuleInfoGroupList { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [XmlElement("project_name")]
        public string ProjectName { get; set; }
    }
}
