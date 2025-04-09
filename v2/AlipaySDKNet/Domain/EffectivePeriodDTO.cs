using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EffectivePeriodDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EffectivePeriodDTO : AopObject
    {
        /// <summary>
        /// 配送范围生效结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 配送范围生效开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
