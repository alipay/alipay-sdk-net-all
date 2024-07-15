using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniOrderAnxinitemdeliverBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniOrderAnxinitemdeliverBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 安心卡使用明细列表
        /// </summary>
        [XmlArray("order_list")]
        [XmlArrayItem("anxinka_deliver_detail_response")]
        public List<AnxinkaDeliverDetailResponse> OrderList { get; set; }

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
        /// 账单列表数目总数，单位：条目数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
