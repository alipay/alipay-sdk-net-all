using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CrowdSelectTagOpen Data Structure.
    /// </summary>
    [Serializable]
    public class CrowdSelectTagOpen : AopObject
    {
        /// <summary>
        /// 分类的标签值列表
        /// </summary>
        [XmlArray("category_tag_option_list")]
        [XmlArrayItem("crowd_select_tag_category_open")]
        public List<CrowdSelectTagCategoryOpen> CategoryTagOptionList { get; set; }

        /// <summary>
        /// 标签id，通过标签创建人群时使用
        /// </summary>
        [XmlElement("tag_id")]
        public long TagId { get; set; }

        /// <summary>
        /// 地域、人生阶段、职业等
        /// </summary>
        [XmlElement("tag_name")]
        public string TagName { get; set; }
    }
}
