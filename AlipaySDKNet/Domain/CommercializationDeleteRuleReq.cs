using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommercializationDeleteRuleReq Data Structure.
    /// </summary>
    [Serializable]
    public class CommercializationDeleteRuleReq : AopObject
    {
        /// <summary>
        /// 提交唯一标识，幂等性验证
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 规则编码
        /// </summary>
        [XmlElement("rule_code")]
        public string RuleCode { get; set; }

        /// <summary>
        /// 所属场景编码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
