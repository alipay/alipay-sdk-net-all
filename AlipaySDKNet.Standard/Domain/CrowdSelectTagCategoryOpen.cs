using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CrowdSelectTagCategoryOpen Data Structure.
    /// </summary>
    [Serializable]
    public class CrowdSelectTagCategoryOpen : AopObject
    {
        /// <summary>
        /// 标签可选项范围分类ID，通过标签创建人群时使用
        /// </summary>
        [XmlElement("tag_option_category_id")]
        public long TagOptionCategoryId { get; set; }

        /// <summary>
        /// 标签可选项范围分类名称
        /// </summary>
        [XmlElement("tag_option_category_name")]
        public string TagOptionCategoryName { get; set; }

        /// <summary>
        /// 可选标签值列表
        /// </summary>
        [XmlArray("tag_option_list")]
        [XmlArrayItem("crowd_select_tag_option_open")]
        public List<CrowdSelectTagOptionOpen> TagOptionList { get; set; }
    }
}
