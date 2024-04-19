using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CategoryDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CategoryDTO : AopObject
    {
        /// <summary>
        /// 门店码类目ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 叶子节点类目列表
        /// </summary>
        [XmlArray("leaf_cates")]
        [XmlArrayItem("category_leaf_d_t_o")]
        public List<CategoryLeafDTO> LeafCates { get; set; }

        /// <summary>
        /// 门店码类目名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
