using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRecycleOrderDelegateBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceRecycleOrderDelegateBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 订单内容
        /// </summary>
        [XmlArray("order_list")]
        [XmlArrayItem("recycle_std_order_all_v_o")]
        public List<RecycleStdOrderAllVO> OrderList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页条数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 订单调试
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }
    }
}
