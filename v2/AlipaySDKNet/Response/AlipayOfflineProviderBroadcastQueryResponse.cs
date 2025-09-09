using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderBroadcastQueryResponse.
    /// </summary>
    public class AlipayOfflineProviderBroadcastQueryResponse : AopResponse
    {
        /// <summary>
        /// 语音播报数据集合
        /// </summary>
        [XmlArray("broadcast_report_list")]
        [XmlArrayItem("broadcast_report_item")]
        public List<BroadcastReportItem> BroadcastReportList { get; set; }
    }
}
