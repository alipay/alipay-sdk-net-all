using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommercializationCustomizeRuleReq Data Structure.
    /// </summary>
    [Serializable]
    public class CommercializationCustomizeRuleReq : AopObject
    {
        /// <summary>
        /// 规则关注度： 驳回 BLOCK 提醒 ATTENTION
        /// </summary>
        [XmlElement("attention_level")]
        public string AttentionLevel { get; set; }

        /// <summary>
        /// 禁用词
        /// </summary>
        [XmlArray("black_list")]
        [XmlArrayItem("string")]
        public List<string> BlackList { get; set; }

        /// <summary>
        /// 提交唯一标识，幂等性验证
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 必备词
        /// </summary>
        [XmlArray("required_list")]
        [XmlArrayItem("string")]
        public List<string> RequiredList { get; set; }

        /// <summary>
        /// 风险等级： 低 LOW 中 MID 高 HIGH
        /// </summary>
        [XmlElement("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// 默认风险提示
        /// </summary>
        [XmlElement("risk_tips")]
        public string RiskTips { get; set; }

        /// <summary>
        /// 规则编码，新增不传，修改时传
        /// </summary>
        [XmlElement("rule_code")]
        public string RuleCode { get; set; }

        /// <summary>
        /// 规则描述
        /// </summary>
        [XmlElement("rule_desc")]
        public string RuleDesc { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [XmlElement("rule_name")]
        public string RuleName { get; set; }

        /// <summary>
        /// 所属场景编码，不可修改
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 豁免词
        /// </summary>
        [XmlArray("white_list")]
        [XmlArrayItem("string")]
        public List<string> WhiteList { get; set; }
    }
}
