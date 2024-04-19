using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CrowdSelectTagOptionOpen Data Structure.
    /// </summary>
    [Serializable]
    public class CrowdSelectTagOptionOpen : AopObject
    {
        /// <summary>
        /// 二级标签值列表
        /// </summary>
        [XmlArray("children")]
        [XmlArrayItem("crowd_select_tag_sub_option_open")]
        public List<CrowdSelectTagSubOptionOpen> Children { get; set; }

        /// <summary>
        /// 标签值中文名称
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }

        /// <summary>
        /// 标签值，通过标签创建人群时使用
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
