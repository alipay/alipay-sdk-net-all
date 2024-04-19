using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseMonitorAlarmruleModifyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseMonitorAlarmruleModifyResponse : AopResponse
    {
        /// <summary>
        /// 更新结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
