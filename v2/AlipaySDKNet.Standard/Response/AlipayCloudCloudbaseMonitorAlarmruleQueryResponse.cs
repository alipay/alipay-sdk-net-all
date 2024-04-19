using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseMonitorAlarmruleQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseMonitorAlarmruleQueryResponse : AopResponse
    {
        /// <summary>
        /// 告警规则列表
        /// </summary>
        [XmlArray("alarm_rules")]
        [XmlArrayItem("alarm_rule")]
        public List<AlarmRule> AlarmRules { get; set; }

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
