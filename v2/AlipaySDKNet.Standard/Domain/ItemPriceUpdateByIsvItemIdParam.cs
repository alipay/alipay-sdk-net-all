using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemPriceUpdateByIsvItemIdParam Data Structure.
    /// </summary>
    [Serializable]
    public class ItemPriceUpdateByIsvItemIdParam : AopObject
    {
        /// <summary>
        /// 服务商商品id
        /// </summary>
        [XmlElement("isv_item_id")]
        public string IsvItemId { get; set; }

        /// <summary>
        /// 价格，单位元。币种 ：人民币。
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }
    }
}
