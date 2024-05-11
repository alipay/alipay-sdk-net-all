using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SimpleOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SimpleOrderInfo : AopObject
    {
        /// <summary>
        /// 订单的商品信息，包括商品数量、价格、ItemId
        /// </summary>
        [XmlArray("item_info_list")]
        [XmlArrayItem("rent_item_info")]
        public List<RentItemInfo> ItemInfoList { get; set; }

        /// <summary>
        /// 交易组件的订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 包含订单的金额信息，包括订单金额、运费信息、优惠信息等
        /// </summary>
        [XmlElement("price_info")]
        public RentPriceInfo PriceInfo { get; set; }
    }
}
