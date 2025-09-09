using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EtravelHotelSupplyPromotion Data Structure.
    /// </summary>
    [Serializable]
    public class EtravelHotelSupplyPromotion : AopObject
    {
        /// <summary>
        /// 可对用户展示优惠信息
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 1 立减金额，2 百分比优惠
        /// </summary>
        [XmlElement("discount_type")]
        public long DiscountType { get; set; }

        /// <summary>
        /// 促销活动类型，多日相同促销活动，此值相同，可用于订单总价优惠活动计算
        /// </summary>
        [XmlElement("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// 用于区分多种促销活动，例如 提前预订优惠:BookAhead,HotelDiscount：优享促销 PromotionAndReduction：促销立减
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }

        /// <summary>
        /// 1 用户（基于用户身份促销），2  商品促销,3 商家促销，4 平台促销 ，5 其他
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 促销立减金额传具体立减金额，单位:元 百分比优惠传小数（0.92），单位:%
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
