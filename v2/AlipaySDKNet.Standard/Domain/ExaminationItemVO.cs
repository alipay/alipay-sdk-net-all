using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExaminationItemVO Data Structure.
    /// </summary>
    [Serializable]
    public class ExaminationItemVO : AopObject
    {
        /// <summary>
        /// 折扣后的金额(实际支付金额)，单位：元。币种：人民币
        /// </summary>
        [XmlElement("amount_discount_amount")]
        public string AmountDiscountAmount { get; set; }

        /// <summary>
        /// 商品总价，单位：元。币种：人民币
        /// </summary>
        [XmlElement("amount_item")]
        public string AmountItem { get; set; }

        /// <summary>
        /// 耗材价格，单位：元。币种：人民币
        /// </summary>
        [XmlElement("consumable_amount")]
        public string ConsumableAmount { get; set; }

        /// <summary>
        /// 优惠信息
        /// </summary>
        [XmlElement("discount")]
        public ExaminationDiscount Discount { get; set; }

        /// <summary>
        /// 药品价格，单位：元。币种：人民币
        /// </summary>
        [XmlElement("drug_amount")]
        public string DrugAmount { get; set; }

        /// <summary>
        /// 商家的商品店内码，对应商品接口中的sku_code
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 商品单价，单位：元。币种：人民币
        /// </summary>
        [XmlElement("price_sale")]
        public string PriceSale { get; set; }

        /// <summary>
        /// 数量，单位：个
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// sku编码
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
