using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentItemDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RentItemDetail : AopObject
    {
        /// <summary>
        /// 租赁商品类目，具体类目信息见<a href="https://opendocs.alipay.com/open/10719">https://opendocs.alipay.com/open/10719</a>
        /// </summary>
        [XmlElement("goods_category")]
        public string GoodsCategory { get; set; }

        /// <summary>
        /// 租赁商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 外部商品ID
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 外部SKU标识
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 租赁商品数量，单位为个
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 是否监管机
        /// </summary>
        [XmlElement("supervised")]
        public bool Supervised { get; set; }

        /// <summary>
        /// 单个商品价格。单位:元，精度:分
        /// </summary>
        [XmlElement("unit_price")]
        public string UnitPrice { get; set; }
    }
}
