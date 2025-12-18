using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderBroadcastBatchqueryResponse.
    /// </summary>
    public class AlipayOfflineProviderBroadcastBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 语音播报数据集合
        /// </summary>
        [XmlArray("broadcast_report_list")]
        [XmlArrayItem("broadcast_report_item")]
        public List<BroadcastReportItem> BroadcastReportList { get; set; }

        /// <summary>
        /// 分页每页大小
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 数据总条数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
