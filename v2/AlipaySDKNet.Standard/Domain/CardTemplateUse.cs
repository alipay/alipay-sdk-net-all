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
        /// 周期付场景下预约链接，填写小程序地址。当card_type= PERIOD_PAY时生效。
        /// </summary>
        [XmlElement("reservation_url")]
        public string ReservationUrl { get; set; }

        /// <summary>
        /// 周期卡是否全部门店
        /// </summary>
        [XmlElement("show_shop")]
        public string ShowShop { get; set; }

        /// <summary>
        /// 可用次数或期数
        /// </summary>
        [XmlElement("usable_count")]
        public long UsableCount { get; set; }

        /// <summary>
        /// 传入指定卡的可用门店ID
        /// </summary>
        [XmlArray("usable_shop_list")]
        [XmlArrayItem("string")]
        public List<string> UsableShopList { get; set; }

        /// <summary>
        /// 使用说明
        /// </summary>
        [XmlElement("use_instruction")]
        public string UseInstruction { get; set; }

        /// <summary>
        /// 用户可选的使用方式。当card_type= TIMES_CARD时生效。不传默认为到店亮码使用。
        /// </summary>
        [XmlArray("use_method")]
        [XmlArrayItem("card_use_method_info")]
        public List<CardUseMethodInfo> UseMethod { get; set; }
    }
}
