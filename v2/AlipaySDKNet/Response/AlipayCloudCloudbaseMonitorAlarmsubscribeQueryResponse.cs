using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseMonitorAlarmsubscribeQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseMonitorAlarmsubscribeQueryResponse : AopResponse
    {
        /// <summary>
        /// 报警规则订阅集合
        /// </summary>
        [XmlArray("alarm_subscribes")]
        [XmlArrayItem("alarm_subscribe")]
        public List<AlarmSubscribe> AlarmSubscribes { get; set; }
    }
}
