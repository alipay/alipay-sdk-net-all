using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardTemplateUse Data Structure.
    /// </summary>
    [Serializable]
    public class CardTemplateUse : AopObject
    {
        /// <summary>
        /// 周期付需要配置周期信息
        /// </summary>
        [XmlElement("cycle_info")]
        public CardCycle CycleInfo { get; set; }

        /// <summary>
        /// 周期付可以配置用户退订购单规则，次卡不需要传该参数
        /// </summary>
        [XmlElement("discount_recover_rule_info")]
        public CardDiscountRecoverRule DiscountRecoverRuleInfo { get; set; }

        /// <summary>
        /// 有效期，天。周期付可不传
        /// </summary>
        [XmlElement("expire_period")]
        public long ExpirePeriod { get; set; }

        /// <summary>
        /// 每期价格
        /// </summary>
        [XmlArray("period_price_list")]
        [XmlArrayItem("card_period_price")]
        public List<CardPeriodPrice> PeriodPriceList { get; set; }

        /// <summary>
        /// 可用次数或期数
        /// </summary>
        [XmlElement("usable_count")]
        public long UsableCount { get; set; }

        /// <summary>
        /// 传入指定商品的可用门店ID
        /// </summary>
        [XmlArray("usable_shop_list")]
        [XmlArrayItem("string")]
        public List<string> UsableShopList { get; set; }

        /// <summary>
        /// 使用说明
        /// </summary>
        [XmlElement("use_instruction")]
        public string UseInstruction { get; set; }
    }
}
