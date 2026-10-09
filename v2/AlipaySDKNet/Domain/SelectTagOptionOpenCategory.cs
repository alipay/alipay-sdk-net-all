using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SelectTagOptionOpenCategory Data Structure.
    /// </summary>
    [Serializable]
    public class SelectTagOptionOpenCategory : AopObject
    {
        /// <summary>
        /// 可选标签值列表
        /// </summary>
        [XmlElement("options")]
        public TagOptionCategoryOpenDetail Options { get; set; }

        /// <summary>
        /// 标签可选项范围分类ID
        /// </summary>
        [XmlElement("tag_option_category_id")]
        public long TagOptionCategoryId { get; set; }

        /// <summary>
        /// 标签可选项范围分类名称
        /// </summary>
        [XmlElement("tag_option_category_name")]
        public string TagOptionCategoryName { get; set; }

        /// <summary>
        /// 标签可选项范围类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
