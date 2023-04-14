using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingActivityBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 活动摘要信息
        /// </summary>
        [XmlArray("activity_lite_infos")]
        [XmlArrayItem("activity_lite_info")]
        public List<ActivityLiteInfo> ActivityLiteInfos { get; set; }

        /// <summary>
        /// 分页查询页码。
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询单页数据条数。
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 经过条件筛选，查询到的活动总数量
        /// </summary>
        [XmlElement("total_size")]
        public string TotalSize { get; set; }
    }
}
