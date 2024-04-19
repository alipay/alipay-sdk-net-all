using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseMonitorAlarmhistoryQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseMonitorAlarmhistoryQueryResponse : AopResponse
    {
        /// <summary>
        /// 告警历史信息
        /// </summary>
        [XmlArray("alarm_histories")]
        [XmlArrayItem("alarm_history")]
        public List<AlarmHistory> AlarmHistories { get; set; }
    }
}
