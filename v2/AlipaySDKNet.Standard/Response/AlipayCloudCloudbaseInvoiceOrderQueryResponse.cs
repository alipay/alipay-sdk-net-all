using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseInvoiceOrderQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseInvoiceOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 消费订单列表
        /// </summary>
        [XmlArray("consume_orders")]
        [XmlArrayItem("consume_order")]
        public List<ConsumeOrder> ConsumeOrders { get; set; }

        /// <summary>
        /// 信息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }
    }
}
