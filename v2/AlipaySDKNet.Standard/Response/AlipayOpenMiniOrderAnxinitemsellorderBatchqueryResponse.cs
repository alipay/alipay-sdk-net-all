using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniOrderAnxinitemsellorderBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniOrderAnxinitemsellorderBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 是否有下一页，true代表有，false代表没有，如果有下一页，使用page_token翻到下一页
        /// </summary>
        [XmlElement("has_next_page")]
        public bool HasNextPage { get; set; }

        /// <summary>
        /// 售卖明细列表
        /// </summary>
        [XmlArray("order_list")]
        [XmlArrayItem("anxin_item_sell_order_detail_response")]
        public List<AnxinItemSellOrderDetailResponse> OrderList { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 下一页需要携带参数查询
        /// </summary>
        [XmlElement("page_token")]
        public string PageToken { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
