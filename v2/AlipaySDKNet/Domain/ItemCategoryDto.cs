using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemCategoryDto Data Structure.
    /// </summary>
    [Serializable]
    public class ItemCategoryDto : AopObject
    {
        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 类目类型
        /// </summary>
        [XmlElement("category_type")]
        public string CategoryType { get; set; }

        /// <summary>
        /// 类目名称-全路径
        /// </summary>
        [XmlElement("full_path_name")]
        public string FullPathName { get; set; }

        /// <summary>
        /// 类目id
        /// </summary>
        [XmlElement("node_id")]
        public string NodeId { get; set; }

        /// <summary>
        /// 类目路径
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }

        /// <summary>
        /// 类目rootId
        /// </summary>
        [XmlElement("root_node_id")]
        public string RootNodeId { get; set; }
    }
}
