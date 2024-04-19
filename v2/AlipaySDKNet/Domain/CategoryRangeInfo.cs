using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CategoryRangeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CategoryRangeInfo : AopObject
    {
        /// <summary>
        /// 最大值，对应0-100分
        /// </summary>
        [XmlElement("high")]
        public long High { get; set; }

        /// <summary>
        /// 最小值，对应0-100分
        /// </summary>
        [XmlElement("low")]
        public long Low { get; set; }
    }
}
