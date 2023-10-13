using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardTemplateUseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CardTemplateUseInfo : AopObject
    {
        /// <summary>
        /// 周期信息
        /// </summary>
        [XmlElement("cycle_info")]
        public CardCycleInfo CycleInfo { get; set; }

        /// <summary>
        /// 有效期
        /// </summary>
        [XmlElement("expire_period")]
        public long ExpirePeriod { get; set; }

        /// <summary>
        /// 卡阶梯价格信息
        /// </summary>
        [XmlArray("period_price_list")]
        [XmlArrayItem("card_period_price_info")]
        public List<CardPeriodPriceInfo> PeriodPriceList { get; set; }

        /// <summary>
        /// 卡可使用次数
        /// </summary>
        [XmlElement("usable_count")]
        public long UsableCount { get; set; }

        /// <summary>
        /// 可使用门店列表
        /// </summary>
        [XmlArray("usable_shop_list")]
        [XmlArrayItem("card_usable_shop_info")]
        public List<CardUsableShopInfo> UsableShopList { get; set; }

        /// <summary>
        /// 使用规则说明
        /// </summary>
        [XmlElement("use_instruction")]
        public string UseInstruction { get; set; }
    }
}
