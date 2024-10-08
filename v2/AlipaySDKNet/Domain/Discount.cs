using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Discount Data Structure.
    /// </summary>
    [Serializable]
    public class Discount : AopObject
    {
        /// <summary>
        /// 金额收益列表
        /// </summary>
        [XmlArray("benefit_amounts")]
        [XmlArrayItem("benefit_amount")]
        public List<BenefitAmount> BenefitAmounts { get; set; }

        /// <summary>
        /// 辅营/返现/立减/优惠带来的优惠金额的tag（名称），能给对应的优惠产生关联
        /// </summary>
        [XmlElement("benefit_desc")]
        public string BenefitDesc { get; set; }

        /// <summary>
        /// 如优惠券，就是优惠券的金额
        /// </summary>
        [XmlElement("benefit_money")]
        public string BenefitMoney { get; set; }

        /// <summary>
        /// 辅营带来的服务
        /// </summary>
        [XmlArray("benefit_service")]
        [XmlArrayItem("benefit")]
        public List<Benefit> BenefitService { get; set; }

        /// <summary>
        /// 用户优惠需要付出的金钱数量
        /// </summary>
        [XmlElement("cost")]
        public string Cost { get; set; }

        /// <summary>
        /// 优惠名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 如果是返现，领取规则要在这个描述里面，对应用户需要进行的操作，如「落地后领取10元优惠券」
        /// </summary>
        [XmlElement("rule_desc")]
        public string RuleDesc { get; set; }

        /// <summary>
        /// ● AUXILIARY_BUSINESS：辅营 ● CASH_BACK：返现 ● CUT：立减 ● COUPON：优惠券
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
