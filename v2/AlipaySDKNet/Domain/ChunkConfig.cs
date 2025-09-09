using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChunkConfig Data Structure.
    /// </summary>
    [Serializable]
    public class ChunkConfig : AopObject
    {
        /// <summary>
        /// 分段长度，单位tokens
        /// </summary>
        [XmlElement("length")]
        public long Length { get; set; }

        /// <summary>
        /// 分段重叠长度,单位tokens
        /// </summary>
        [XmlElement("overlap")]
        public long Overlap { get; set; }

        /// <summary>
        /// 切分策略
        /// </summary>
        [XmlElement("strategy")]
        public string Strategy { get; set; }

        /// <summary>
        /// 切分标识符
        /// </summary>
        [XmlArray("symbols")]
        [XmlArrayItem("string")]
        public List<string> Symbols { get; set; }
    }
}
