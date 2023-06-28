using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniOrderItembillBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniOrderItembillBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 订单对账列表
        /// </summary>
        [XmlArray("order_list")]
        [XmlArrayItem("item_order_bill_detail_response")]
        public List<ItemOrderBillDetailResponse> OrderList { get; set; }

        /// <summary>
        /// 分页页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
