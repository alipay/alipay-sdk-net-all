using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NimitzRange Data Structure.
    /// </summary>
    [Serializable]
    public class NimitzRange : AopObject
    {
        /// <summary>
        /// 范围的最大值
        /// </summary>
        [XmlElement("max")]
        public string Max { get; set; }

        /// <summary>
        /// true: < max false: <= max
        /// </summary>
        [XmlElement("max_exclude")]
        public bool MaxExclude { get; set; }

        /// <summary>
        /// 范围的最小值
        /// </summary>
        [XmlElement("min")]
        public string Min { get; set; }

        /// <summary>
        /// true: > min false: >= min
        /// </summary>
        [XmlElement("min_exclude")]
        public bool MinExclude { get; set; }
    }
}
