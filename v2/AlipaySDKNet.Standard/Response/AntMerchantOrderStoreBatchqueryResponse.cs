using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantOrderStoreBatchqueryResponse.
    /// </summary>
    public class AntMerchantOrderStoreBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 是否有下一页
        /// </summary>
        [XmlElement("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 订单列表
        /// </summary>
        [XmlArray("order_list")]
        [XmlArrayItem("store_order_d_t_o")]
        public List<StoreOrderDTO> OrderList { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页数量
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 查询总数量
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
