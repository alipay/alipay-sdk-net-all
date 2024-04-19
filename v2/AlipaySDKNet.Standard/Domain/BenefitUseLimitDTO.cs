using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitUseLimitDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitUseLimitDTO : AopObject
    {
        /// <summary>
        /// REDUCE_BY  ： 满减; REDUCE_TO ： 减至 (一般用来标识特价商品);GIFT ： 满赠;DISCOUNT ： 折扣
        /// </summary>
        [XmlElement("benefit_content_type")]
        public string BenefitContentType { get; set; }

        /// <summary>
        /// 满返使用限制
        /// </summary>
        [XmlElement("cash_back_info")]
        public CashBackInfoDTO CashBackInfo { get; set; }

        /// <summary>
        /// 使用规则条款描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 折扣使用限制
        /// </summary>
        [XmlElement("discount_info")]
        public DiscountInfoDTO DiscountInfo { get; set; }

        /// <summary>
        /// 满赠
        /// </summary>
        [XmlElement("gift_info")]
        public GiftInfoDTO GiftInfo { get; set; }

        /// <summary>
        /// 满减使用限制
        /// </summary>
        [XmlElement("reduce_by_info")]
        public ReduceByInfoDTO ReduceByInfo { get; set; }

        /// <summary>
        /// 减至使用限制
        /// </summary>
        [XmlElement("reducy_to_info")]
        public ReduceToInfoDTO ReducyToInfo { get; set; }
    }
}
