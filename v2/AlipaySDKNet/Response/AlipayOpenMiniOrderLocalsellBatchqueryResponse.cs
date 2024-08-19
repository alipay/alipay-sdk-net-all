using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniOrderLocalsellBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniOrderLocalsellBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 订单对账列表
        /// </summary>
        [XmlArray("order_list")]
        [XmlArrayItem("item_sell_order_response")]
        public List<ItemSellOrderResponse> OrderList { get; set; }

        /// <summary>
        /// 分页页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小，单位：条目数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 对账账单列表返回的订单总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
