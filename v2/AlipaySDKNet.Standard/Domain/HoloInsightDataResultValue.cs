using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HoloInsightDataResultValue Data Structure.
    /// </summary>
    [Serializable]
    public class HoloInsightDataResultValue : AopObject
    {
        /// <summary>
        /// 数据对应的时间戳
        /// </summary>
        [XmlElement("period")]
        public long Period { get; set; }

        /// <summary>
        /// 指标值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
