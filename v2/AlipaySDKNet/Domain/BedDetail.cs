using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BedDetail Data Structure.
    /// </summary>
    [Serializable]
    public class BedDetail : AopObject
    {
        /// <summary>
        /// 床型长度（m）
        /// </summary>
        [XmlElement("bed_length")]
        public string BedLength { get; set; }

        /// <summary>
        /// 该床型数量
        /// </summary>
        [XmlElement("bed_number")]
        public long BedNumber { get; set; }

        /// <summary>
        /// 床型类型
        /// </summary>
        [XmlElement("bed_type")]
        public string BedType { get; set; }

        /// <summary>
        /// 床型宽度（m）
        /// </summary>
        [XmlElement("bed_width")]
        public string BedWidth { get; set; }
    }
}
