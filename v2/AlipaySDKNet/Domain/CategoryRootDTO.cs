using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CategoryRootDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CategoryRootDTO : AopObject
    {
        /// <summary>
        /// 二级类目列表
        /// </summary>
        [XmlArray("children")]
        [XmlArrayItem("category_d_t_o")]
        public List<CategoryDTO> Children { get; set; }

        /// <summary>
        /// 一级类目ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 一级类目名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
