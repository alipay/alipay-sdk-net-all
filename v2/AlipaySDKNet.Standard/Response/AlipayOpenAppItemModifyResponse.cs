using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppItemModifyResponse.
    /// </summary>
    public class AlipayOpenAppItemModifyResponse : AopResponse
    {
        /// <summary>
        /// 商品业务模式，租赁业务模式包含（短租：0；长租：1；先租后买 ： 2）
        /// </summary>
        [XmlElement("business_model")]
        public string BusinessModel { get; set; }

        /// <summary>
        /// 支付宝平台侧spu ID，是支付宝平台侧商品的唯一标识，后续与平台交互，需要使用该 ID，建议持久化。
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商家侧spu商品 ID，要求 APPID 下全局唯一.
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// sku数组
        /// </summary>
        [XmlArray("skus")]
        [XmlArrayItem("item_sku_id_pair")]
        public List<ItemSkuIdPair> Skus { get; set; }
    }
}
