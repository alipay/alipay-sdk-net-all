using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardPriceRequestItem Data Structure.
    /// </summary>
    [Serializable]
    public class CardPriceRequestItem : AopObject
    {
        /// <summary>
        /// 优惠卡原价，单位为分
        /// </summary>
        [XmlElement("base_price_cent")]
        public long BasePriceCent { get; set; }

        /// <summary>
        /// 优惠卡类型，枚举值为 mcard(月卡),ycard(年卡)
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 进价(调用方建议价格)，单位为分
        /// </summary>
        [XmlElement("default_promo_price_cent")]
        public long DefaultPromoPriceCent { get; set; }

        /// <summary>
        /// 优惠卡价格区间上限，单位为分
        /// </summary>
        [XmlElement("high_price_cent")]
        public long HighPriceCent { get; set; }

        /// <summary>
        /// 当前请求的周期卡价格(用于不需要定价的情况),单位为分
        /// </summary>
        [XmlElement("last_promo_price")]
        public long LastPromoPrice { get; set; }

        /// <summary>
        /// 优惠卡价格区间下限，单位为分
        /// </summary>
        [XmlElement("lower_price_cent")]
        public long LowerPriceCent { get; set; }

        /// <summary>
        /// 是否定价，默认为true
        /// </summary>
        [XmlElement("pricing")]
        public bool Pricing { get; set; }

        /// <summary>
        /// 用户是否可购买，默认为true
        /// </summary>
        [XmlElement("visible")]
        public bool Visible { get; set; }
    }
}
