using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentItemInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentItemInfoDTO : AopObject
    {
        /// <summary>
        /// <a href="https://opendocs.alipay.com/open/10719">请参考租赁商品类目文档</a>
        /// </summary>
        [XmlElement("goods_category")]
        public string GoodsCategory { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("item_cnt")]
        public long ItemCnt { get; set; }

        /// <summary>
        /// 商户侧商品id
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 外部商品ID
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 商品单价，单位：元，精确到小数点后两位，例如租赁商品请传入日租，10元/天
        /// </summary>
        [XmlElement("sale_price")]
        public string SalePrice { get; set; }
    }
}
