using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MemberCardPayEffectiveRule Data Structure.
    /// </summary>
    [Serializable]
    public class MemberCardPayEffectiveRule : AopObject
    {
        /// <summary>
        /// 会员卡线下核销的商品规则
        /// </summary>
        [XmlElement("item_rule")]
        public MemberCardPayEffectiveItemRule ItemRule { get; set; }

        /// <summary>
        /// 线下店核销范围规则
        /// </summary>
        [XmlArray("shop_rules")]
        [XmlArrayItem("member_card_pay_effective_shop_rule")]
        public List<MemberCardPayEffectiveShopRule> ShopRules { get; set; }

        /// <summary>
        /// 间连商家的编号列表，暂不支持，最大列表数为0
        /// </summary>
        [XmlArray("smids")]
        [XmlArrayItem("string")]
        public List<string> Smids { get; set; }
    }
}
