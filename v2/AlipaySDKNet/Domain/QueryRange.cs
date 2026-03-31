using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QueryRange Data Structure.
    /// </summary>
    [Serializable]
    public class QueryRange : AopObject
    {
        /// <summary>
        /// 查询范围的结束时间戳
        /// </summary>
        [XmlElement("end")]
        public string End { get; set; }

        /// <summary>
        /// 是否包含结束时间点，true表示包含，false表示不包含
        /// </summary>
        [XmlElement("include_end")]
        public bool IncludeEnd { get; set; }

        /// <summary>
        /// 是否包含起始时间点，true表示包含，false表示不包含
        /// </summary>
        [XmlElement("include_start")]
        public bool IncludeStart { get; set; }

        /// <summary>
        /// 查询范围的起始时间戳
        /// </summary>
        [XmlElement("start")]
        public string Start { get; set; }
    }
}
