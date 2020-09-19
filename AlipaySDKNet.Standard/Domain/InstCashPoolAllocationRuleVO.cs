using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InstCashPoolAllocationRuleVO Data Structure.
    /// </summary>
    [Serializable]
    public class InstCashPoolAllocationRuleVO : AopObject
    {
        /// <summary>
        /// 机构账号
        /// </summary>
        [XmlElement("inst_account")]
        public InstAccountDTO InstAccount { get; set; }

        /// <summary>
        /// 机构自定义备注
        /// </summary>
        [XmlElement("inst_rule_custom_memo")]
        public InstRuleCustomMemoVO InstRuleCustomMemo { get; set; }

        /// <summary>
        /// 限额水位
        /// </summary>
        [XmlElement("limit_water_line")]
        public string LimitWaterLine { get; set; }

        /// <summary>
        /// 规则备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 是否需要自定义备注
        /// </summary>
        [XmlElement("need_custom_memo")]
        public bool NeedCustomMemo { get; set; }

        /// <summary>
        /// 操作员名称
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 父机构类型
        /// </summary>
        [XmlElement("parent_inst_account")]
        public InstAccountDTO ParentInstAccount { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [XmlElement("rule_name")]
        public string RuleName { get; set; }

        /// <summary>
        /// 规则优先级
        /// </summary>
        [XmlElement("rule_order")]
        public long RuleOrder { get; set; }

        /// <summary>
        /// INITIAL/RUN/STOP，初始态/运行态/暂停态
        /// </summary>
        [XmlElement("rule_status")]
        public string RuleStatus { get; set; }

        /// <summary>
        /// 上划规则/下拨规则，UP_WARD_RULE/DOWN_WARD_RULE
        /// </summary>
        [XmlElement("rule_type")]
        public string RuleType { get; set; }

        /// <summary>
        /// 目标水位线
        /// </summary>
        [XmlElement("target_water_line")]
        public string TargetWaterLine { get; set; }
    }
}
