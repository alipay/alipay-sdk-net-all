using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LibraryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LibraryInfo : AopObject
    {
        /// <summary>
        /// 知识库ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 知识库名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 类目ID
        /// </summary>
        [XmlElement("tree_id")]
        public long TreeId { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }
    }
}
