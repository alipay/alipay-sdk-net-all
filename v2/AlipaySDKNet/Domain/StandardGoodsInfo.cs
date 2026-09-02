using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StandardGoodsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class StandardGoodsInfo : AopObject
    {
        /// <summary>
        /// 商品分类
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品数量，无具体度量单位
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 单位金额
        /// </summary>
        [XmlElement("unit_amount")]
        public MultiCurrencyMoneyDTO UnitAmount { get; set; }
    }
}
