using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseMonitorCdnreportGetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseMonitorCdnreportGetResponse : AopResponse
    {
        /// <summary>
        /// 报表数据
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
