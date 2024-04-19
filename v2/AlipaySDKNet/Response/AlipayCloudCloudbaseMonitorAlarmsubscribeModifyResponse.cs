using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseMonitorAlarmsubscribeModifyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseMonitorAlarmsubscribeModifyResponse : AopResponse
    {
        /// <summary>
        /// 报警规则订阅结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
