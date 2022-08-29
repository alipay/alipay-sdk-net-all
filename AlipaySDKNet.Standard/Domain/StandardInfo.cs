using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StandardInfo Data Structure.
    /// </summary>
    [Serializable]
    public class StandardInfo : AopObject
    {
        /// <summary>
        /// 消费模式，不填为默认模式，枚举值：COUPON_ONLY（仅支持点券） COUPON_AND_CAP（支持点券+余额） DEFAULT（默认模式） 点券：消费时找员工的点券，没有或者用完了不可付； 点券+余额：消费时找员工的点券，没有找员工的余额，没有或者用完了不可付。 默认：有给员工设置员工余额以员工余额为准，用完为止。否则只受规则里的限额和企业账户资金上限管控；
        /// </summary>
        [XmlElement("consume_mode")]
        public string ConsumeMode { get; set; }

        /// <summary>
        /// 开票规则id
        /// </summary>
        [XmlElement("open_rule_id")]
        public string OpenRuleId { get; set; }

        /// <summary>
        /// 外部使用规则id，制度内使用规则该字段不允许重复
        /// </summary>
        [XmlElement("outer_source_id")]
        public string OuterSourceId { get; set; }

        /// <summary>
        /// 支付策略 当笔消费金额大于规则可用余额时，用于控制支付策略，该字段缺省时采取因公账户和个人账户组合支付策略， 枚举值：PERSONAL（全部个人账户支付）, COMBINATION（因公账户和个人账户组合支付）
        /// </summary>
        [XmlElement("payment_policy")]
        public string PaymentPolicy { get; set; }

        /// <summary>
        /// 使用规则条件列表
        /// </summary>
        [XmlArray("standard_condition_info_list")]
        [XmlArrayItem("standard_condition_info")]
        public List<StandardConditionInfo> StandardConditionInfoList { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [XmlElement("standard_name")]
        public string StandardName { get; set; }
    }
}
