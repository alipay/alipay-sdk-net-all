using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MallPayGroupApplyRule Data Structure.
    /// </summary>
    [Serializable]
    public class MallPayGroupApplyRule : AopObject
    {
        /// <summary>
        /// 业务规则Id
        /// </summary>
        [XmlElement("biz_rule_id")]
        public string BizRuleId { get; set; }

        /// <summary>
        /// 业务规则名称
        /// </summary>
        [XmlElement("biz_rule_name")]
        public string BizRuleName { get; set; }

        /// <summary>
        /// 规则范围类型，ALL：全场，SHOP_LIMIT：门店范围
        /// </summary>
        [XmlElement("biz_rule_type")]
        public string BizRuleType { get; set; }

        /// <summary>
        /// VALID：有效  INVALID：无效
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
