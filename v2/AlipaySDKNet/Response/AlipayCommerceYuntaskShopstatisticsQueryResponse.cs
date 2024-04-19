using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskShopstatisticsQueryResponse.
    /// </summary>
    public class AlipayCommerceYuntaskShopstatisticsQueryResponse : AopResponse
    {
        /// <summary>
        /// 分页
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 页面大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 统计数据
        /// </summary>
        [XmlArray("task_shop_statistic_info")]
        [XmlArrayItem("yun_task_shop_statistic_info")]
        public List<YunTaskShopStatisticInfo> TaskShopStatisticInfo { get; set; }

        /// <summary>
        /// 结果总数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
