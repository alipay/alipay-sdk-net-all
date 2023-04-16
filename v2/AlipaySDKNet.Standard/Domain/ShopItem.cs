using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopItem Data Structure.
    /// </summary>
    [Serializable]
    public class ShopItem : AopObject
    {
        /// <summary>
        /// 店铺内商品列表
        /// </summary>
        [XmlArray("goods")]
        [XmlArrayItem("aos_good_item")]
        public List<AosGoodItem> Goods { get; set; }

        /// <summary>
        /// 分值
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }

        /// <summary>
        /// 店铺的id信息
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺的名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺的跳转地址
        /// </summary>
        [XmlElement("shop_url")]
        public string ShopUrl { get; set; }

        /// <summary>
        /// 搜索结果item的trace_id用于关联搜索结果和用户行为
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
