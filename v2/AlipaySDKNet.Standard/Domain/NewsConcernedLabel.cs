using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NewsConcernedLabel Data Structure.
    /// </summary>
    [Serializable]
    public class NewsConcernedLabel : AopObject
    {
        /// <summary>
        /// 标签定义编号
        /// </summary>
        [XmlElement("label_code")]
        public string LabelCode { get; set; }

        /// <summary>
        /// 标签说明
        /// </summary>
        [XmlElement("label_name")]
        public string LabelName { get; set; }

        /// <summary>
        /// 标签类型显示名称
        /// </summary>
        [XmlElement("label_show_name")]
        public string LabelShowName { get; set; }

        /// <summary>
        /// 标签类型定义
        /// </summary>
        [XmlElement("label_type")]
        public string LabelType { get; set; }
    }
}
