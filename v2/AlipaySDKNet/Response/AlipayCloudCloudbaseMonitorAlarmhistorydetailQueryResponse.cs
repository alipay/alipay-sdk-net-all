using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseMonitorAlarmhistorydetailQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseMonitorAlarmhistorydetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 报警历史详情
        /// </summary>
        [XmlArray("alarm_history_details")]
        [XmlArrayItem("alarm_history_detail")]
        public List<AlarmHistoryDetail> AlarmHistoryDetails { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

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
    }
}
