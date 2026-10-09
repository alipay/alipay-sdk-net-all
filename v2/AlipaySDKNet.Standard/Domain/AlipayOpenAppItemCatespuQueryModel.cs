using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppItemCatespuQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppItemCatespuQueryModel : AopObject
    {
        /// <summary>
        /// 类目ID，查询类目信息获取叶子类目ID
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("key_attrs")]
        [XmlArrayItem("key_attribute_query_request")]
        public List<KeyAttributeQueryRequest> KeyAttrs { get; set; }

        /// <summary>
        /// 分页查询的页码。默认从1开始
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询的每页记录数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
