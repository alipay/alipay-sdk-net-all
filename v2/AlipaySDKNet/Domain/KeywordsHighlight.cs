using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KeywordsHighlight Data Structure.
    /// </summary>
    [Serializable]
    public class KeywordsHighlight : AopObject
    {
        /// <summary>
        /// 将搜索关键字用<em>进行高亮显示
        /// </summary>
        [XmlArray("searchable_text")]
        [XmlArrayItem("string")]
        public List<string> SearchableText { get; set; }

        /// <summary>
        /// 摘要的高亮字段
        /// </summary>
        [XmlArray("summary")]
        [XmlArrayItem("string")]
        public List<string> Summary { get; set; }

        /// <summary>
        /// 将标题关键字高亮显示
        /// </summary>
        [XmlArray("title")]
        [XmlArrayItem("string")]
        public List<string> Title { get; set; }
    }
}
