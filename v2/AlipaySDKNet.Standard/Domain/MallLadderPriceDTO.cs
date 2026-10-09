using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MallLadderPriceDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MallLadderPriceDTO : AopObject
    {
        /// <summary>
        /// 阶梯价格关联的商品报价Id值
        /// </summary>
        [XmlElement("goods_quotation_id")]
        public long GoodsQuotationId { get; set; }

        /// <summary>
        /// 规格报价的最小采购量数字从 1开始, 根据报价单位进行度量 如天、个、块等
        /// </summary>
        [XmlElement("minimum_purchase_quantity")]
        public string MinimumPurchaseQuantity { get; set; }

        /// <summary>
        /// 规格报价数量单价,通过报价单上币种来确定具体价格， 这里只进行价格数字的透出, 具体单价币种需要取 currency_code字段返回的值
        /// </summary>
        [XmlElement("unit_price")]
        public string UnitPrice { get; set; }
    }
}
