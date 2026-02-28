using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalOverallMetric Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalOverallMetric : AopObject
    {
        /// <summary>
        /// 日均服务次数
        /// </summary>
        [XmlElement("avg_service_pv_30d")]
        public long AvgServicePv30d { get; set; }
    }
}
