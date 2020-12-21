using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchBaseItems Data Structure.
    /// </summary>
    [Serializable]
    public class SearchBaseItems : AopObject
    {
        /// <summary>
        /// 搜索可见性
        /// </summary>
        [XmlElement("can_search")]
        public bool CanSearch { get; set; }

        /// <summary>
        /// 提报关键词列表
        /// </summary>
        [XmlArray("key_words")]
        [XmlArrayItem("string")]
        public List<string> KeyWords { get; set; }
    }
}
