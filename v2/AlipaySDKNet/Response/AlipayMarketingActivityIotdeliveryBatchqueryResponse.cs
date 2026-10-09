using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityIotdeliveryBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingActivityIotdeliveryBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码，从1开始计算
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("items_page")]
        public long ItemsPage { get; set; }

        /// <summary>
        /// 投放计划列表
        /// </summary>
        [XmlArray("plan_list")]
        [XmlArrayItem("io_t_delivery_plan")]
        public List<IoTDeliveryPlan> PlanList { get; set; }

        /// <summary>
        /// 查询到的总结果数
        /// </summary>
        [XmlElement("total_items")]
        public long TotalItems { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }
    }
}
