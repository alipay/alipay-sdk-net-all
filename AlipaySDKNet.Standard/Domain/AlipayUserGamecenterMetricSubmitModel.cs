using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserGamecenterMetricSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserGamecenterMetricSubmitModel : AopObject
    {
        /// <summary>
        /// 游戏侧业务指标内容，格式为json，key为指标编码，value为指标值
        /// </summary>
        [XmlElement("metric_content")]
        public string MetricContent { get; set; }

        /// <summary>
        /// 指标上报时间
        /// </summary>
        [XmlElement("metric_date")]
        public string MetricDate { get; set; }
    }
}
