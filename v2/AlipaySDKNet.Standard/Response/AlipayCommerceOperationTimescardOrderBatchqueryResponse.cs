using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationTimescardOrderBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceOperationTimescardOrderBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 次卡订单信息
        /// </summary>
        [XmlArray("datas")]
        [XmlArrayItem("time_card_order_info")]
        public List<TimeCardOrderInfo> Datas { get; set; }

        /// <summary>
        /// 分页页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页每页记录数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总的记录数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
