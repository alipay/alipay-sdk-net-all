using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TradingQueryRange Data Structure.
    /// </summary>
    [Serializable]
    public class TradingQueryRange : AopObject
    {
        /// <summary>
        /// 结束时间的时间戳，单位为毫秒
        /// </summary>
        [XmlElement("end")]
        public long End { get; set; }

        /// <summary>
        /// 是否包含结束时间
        /// </summary>
        [XmlElement("include_end")]
        public bool IncludeEnd { get; set; }

        /// <summary>
        /// 是否包含开始时间
        /// </summary>
        [XmlElement("include_start")]
        public bool IncludeStart { get; set; }

        /// <summary>
        /// 查询开始时间的时间戳，单位为毫秒
        /// </summary>
        [XmlElement("start")]
        public long Start { get; set; }
    }
}
