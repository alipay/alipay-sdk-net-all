using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DateRangeDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DateRangeDTO : AopObject
    {
        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end")]
        public string End { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start")]
        public string Start { get; set; }
    }
}
