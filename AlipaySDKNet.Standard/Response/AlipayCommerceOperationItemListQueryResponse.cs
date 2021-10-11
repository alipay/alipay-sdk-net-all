using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationItemListQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationItemListQueryResponse : AopResponse
    {
        /// <summary>
        /// 奖品列表
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("item_prize_info")]
        public List<ItemPrizeInfo> ItemList { get; set; }
    }
}
