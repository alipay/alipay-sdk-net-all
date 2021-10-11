using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StandardRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class StandardRuleInfo : AopObject
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
        /// 规则列表
        /// </summary>
        [XmlArray("expense_ctrl_rule_info_list")]
        [XmlArrayItem("expense_ctr_rule_info")]
        public List<ExpenseCtrRuleInfo> ExpenseCtrlRuleInfoList { get; set; }

        /// <summary>
        /// 费控规则说明
        /// </summary>
        [XmlElement("standard_desc")]
        public string StandardDesc { get; set; }

        /// <summary>
        /// 制度id
        /// </summary>
        [XmlElement("standard_id")]
        public string StandardId { get; set; }

        /// <summary>
        /// 制度名称
        /// </summary>
        [XmlElement("standard_name")]
        public string StandardName { get; set; }
    }
}
