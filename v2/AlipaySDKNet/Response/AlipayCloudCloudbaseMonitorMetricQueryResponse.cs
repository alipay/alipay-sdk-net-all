using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseMonitorMetricQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseMonitorMetricQueryResponse : AopResponse
    {
        /// <summary>
        /// 指标数据（数据样例：[[1693819500000,\"0.0\"],[1693820100000,\"0.0\"]]），整体内部数据展示为【时间戳，数值】的方式
        /// </summary>
        [XmlElement("metrics")]
        public string Metrics { get; set; }
    }
}
