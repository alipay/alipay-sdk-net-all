using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TimeRange Data Structure.
    /// </summary>
    [Serializable]
    public class TimeRange : AopObject
    {
        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("begin")]
        public string Begin { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end")]
        public string End { get; set; }
    }
}
