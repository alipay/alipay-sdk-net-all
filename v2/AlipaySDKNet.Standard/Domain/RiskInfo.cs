using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RiskInfo : AopObject
    {
        /// <summary>
        /// 业务规则 规则相关法律信息，
        /// </summary>
        [XmlElement("biz_rule")]
        public string BizRule { get; set; }

        /// <summary>
        /// 风险提示语
        /// </summary>
        [XmlElement("notice")]
        public string Notice { get; set; }

        /// <summary>
        /// 风险详情列表
        /// </summary>
        [XmlArray("risk_info_detail_list")]
        [XmlArrayItem("risk_info_detail")]
        public List<RiskInfoDetail> RiskInfoDetailList { get; set; }

        /// <summary>
        /// 风险等级，枚举 高,中,低三种
        /// </summary>
        [XmlElement("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// 规则编码
        /// </summary>
        [XmlElement("rule_code")]
        public string RuleCode { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [XmlElement("rule_name")]
        public string RuleName { get; set; }

        /// <summary>
        /// 规则机审结果
        /// </summary>
        [XmlElement("rule_robot_status")]
        public string RuleRobotStatus { get; set; }
    }
}
