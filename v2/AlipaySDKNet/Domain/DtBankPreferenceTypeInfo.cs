using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DtBankPreferenceTypeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DtBankPreferenceTypeInfo : AopObject
    {
        /// <summary>
        /// 折扣立减规则，preference_type取值为discount时，此参数有值
        /// </summary>
        [XmlElement("discount_rule")]
        public DtBankPreferenceDiscountRule DiscountRule { get; set; }

        /// <summary>
        /// 智能立减规则，preference_type取值为intelligentAlgorithm时，此参数有值。
        /// </summary>
        [XmlElement("intelligent_rule")]
        public DtBankPreferenceIntelligentRule IntelligentRule { get; set; }

        /// <summary>
        /// 多阶梯立减规则
        /// </summary>
        [XmlElement("multi_staged_rule")]
        public DtBankPreferenceMultiStagedRule MultiStagedRule { get; set; }

        /// <summary>
        /// 优惠类型
        /// </summary>
        [XmlElement("preference_type")]
        public string PreferenceType { get; set; }

        /// <summary>
        /// 随机金额立减(随机满减)规则，preference_type取值为random时，此参数有值。
        /// </summary>
        [XmlElement("random_rule")]
        public DtBankPreferenceRandomRule RandomRule { get; set; }

        /// <summary>
        /// 定额立减(定额满减)规则，preference_type取值为single时，此参数有值
        /// </summary>
        [XmlElement("single_rule")]
        public DtBankPreferenceSingleRule SingleRule { get; set; }

        /// <summary>
        /// 核销门槛，单位分
        /// </summary>
        [XmlElement("use_threshold")]
        public long UseThreshold { get; set; }
    }
}
