using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TagOptionCategoryOpenDetail Data Structure.
    /// </summary>
    [Serializable]
    public class TagOptionCategoryOpenDetail : AopObject
    {
        /// <summary>
        /// 标签中文名称
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }

        /// <summary>
        /// 标签值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
