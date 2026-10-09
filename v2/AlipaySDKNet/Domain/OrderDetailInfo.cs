using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OrderDetailInfo : AopObject
    {
        /// <summary>
        /// 订单金额（单位 元）
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 订单的商品列表
        /// </summary>
        [XmlArray("item_detail_info_list")]
        [XmlArrayItem("item_detail_info")]
        public List<ItemDetailInfo> ItemDetailInfoList { get; set; }
    }
}
