using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OneCategoryDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OneCategoryDTO : AopObject
    {
        /// <summary>
        /// 类目ID+唯一
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 类目名称+不唯一
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 标签列表+唯一
        /// </summary>
        [XmlArray("tag_dto_list")]
        [XmlArrayItem("tag_d_t_o")]
        public List<TagDTO> TagDtoList { get; set; }

        /// <summary>
        /// 二级标签类目列表+不唯一
        /// </summary>
        [XmlArray("two_category_dto_list")]
        [XmlArrayItem("two_category_d_t_o")]
        public List<TwoCategoryDTO> TwoCategoryDtoList { get; set; }
    }
}
