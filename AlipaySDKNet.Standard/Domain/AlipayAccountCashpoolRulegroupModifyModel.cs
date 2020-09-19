using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAccountCashpoolRulegroupModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountCashpoolRulegroupModifyModel : AopObject
    {
        /// <summary>
        /// 资金池唯一标识
        /// </summary>
        [XmlElement("cash_pool_id")]
        public string CashPoolId { get; set; }

        /// <summary>
        /// UP_WARD_RULE/DOWN_WARD_RULE;上划/下拨
        /// </summary>
        [XmlElement("config_type")]
        public string ConfigType { get; set; }

        /// <summary>
        /// 调拨限额修改
        /// </summary>
        [XmlArray("inst_allocation_quota_vo_list")]
        [XmlArrayItem("inst_allocation_quota_v_o")]
        public List<InstAllocationQuotaVO> InstAllocationQuotaVoList { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 父账户目标水位
        /// </summary>
        [XmlElement("parent_target_water_line")]
        public string ParentTargetWaterLine { get; set; }

        /// <summary>
        /// 规则组唯一标识
        /// </summary>
        [XmlElement("rule_group_id")]
        public string RuleGroupId { get; set; }

        /// <summary>
        /// INITIAL/RUN/STOP，规则组状态，初始/运行/暂停
        /// </summary>
        [XmlElement("rule_group_status")]
        public string RuleGroupStatus { get; set; }

        /// <summary>
        /// 规则触发的cron表达式
        /// </summary>
        [XmlElement("trigger_time")]
        public string TriggerTime { get; set; }

        /// <summary>
        /// 子账户模式/主账户模式，SUB_ACCOUNT_MODE/MAIN_ACCOUNT_MODE
        /// </summary>
        [XmlElement("water_mode")]
        public string WaterMode { get; set; }
    }
}
