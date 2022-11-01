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
        /// 费用类型子类，当制度的费用类型为MEAL时，支持到店、外卖；当费用类型为非MEAL时，与费用类型保持一致
        /// </summary>
        [XmlElement("expense_type_sub_category")]
        public string ExpenseTypeSubCategory { get; set; }

        /// <summary>
        /// 开票规则id，可通过接口alipay.ebpp.invoice.enterpriseconsume.enterpriseopenrule.create 创建并得到开票规则ID
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
        /// 使用规则描述(敏感词校验)
        /// </summary>
        [XmlElement("standard_desc")]
        public string StandardDesc { get; set; }

        /// <summary>
        /// 制度ID（创建使用规则时非必填）
        /// </summary>
        [XmlElement("standard_id")]
        public string StandardId { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [XmlElement("standard_name")]
        public string StandardName { get; set; }
    }
}
