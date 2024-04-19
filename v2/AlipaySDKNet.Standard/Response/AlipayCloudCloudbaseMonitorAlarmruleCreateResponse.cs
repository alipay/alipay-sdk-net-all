using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseMonitorAlarmruleCreateResponse.
    /// </summary>
    public class AlipayCloudCloudbaseMonitorAlarmruleCreateResponse : AopResponse
    {
        /// <summary>
        /// 告警规则ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
