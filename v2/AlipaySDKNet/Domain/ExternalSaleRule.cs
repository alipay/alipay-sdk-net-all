using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExternalSaleRule Data Structure.
    /// </summary>
    [Serializable]
    public class ExternalSaleRule : AopObject
    {
        /// <summary>
        /// 最大单次购买数量PER_ORDER_MAX_BUY_COUNT      购买人年龄限制BUYER_AGE_LIMIT      购买人性别限制BUYER_GENDER_LIMIT
        /// </summary>
        [XmlElement("rule_key")]
        public string RuleKey { get; set; }

        /// <summary>
        /// 最大单次购买数量PER_ORDER_MAX_BUY_COUNT   value: 非负整数(0不限制)        购买人年龄限制BUYER_AGE_LIMIT    value:  NONE/UNDER_18/OVER_18        购买人性别限制BUYER_GENDER_LIMIT    value: NONE/MALE/FEMALE
        /// </summary>
        [XmlElement("rule_value")]
        public string RuleValue { get; set; }
    }
}
