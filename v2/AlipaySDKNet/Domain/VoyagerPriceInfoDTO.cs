using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoyagerPriceInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class VoyagerPriceInfoDTO : AopObject
    {
        /// <summary>
        /// 折扣百分比
        /// </summary>
        [XmlElement("discount_percentage")]
        public long DiscountPercentage { get; set; }

        /// <summary>
        /// 原价
        /// </summary>
        [XmlElement("original_price")]
        public MultiCurrencyMoneyDTO OriginalPrice { get; set; }

        /// <summary>
        /// 原销售价
        /// </summary>
        [XmlElement("original_sale_price")]
        public MultiCurrencyMoneyDTO OriginalSalePrice { get; set; }

        /// <summary>
        /// 平台营销优惠金额
        /// </summary>
        [XmlElement("promo_discount_price")]
        public MultiCurrencyMoneyDTO PromoDiscountPrice { get; set; }

        /// <summary>
        /// 售价（优惠后）
        /// </summary>
        [XmlElement("sale_price")]
        public MultiCurrencyMoneyDTO SalePrice { get; set; }

        /// <summary>
        /// 商家优惠金额
        /// </summary>
        [XmlElement("supplier_discount_price")]
        public MultiCurrencyMoneyDTO SupplierDiscountPrice { get; set; }

        /// <summary>
        /// 优惠总金额
        /// </summary>
        [XmlElement("total_discount_price")]
        public MultiCurrencyMoneyDTO TotalDiscountPrice { get; set; }
    }
}
