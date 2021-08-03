using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BoxExclusiveKeyword Data Structure.
    /// </summary>
    [Serializable]
    public class BoxExclusiveKeyword : AopObject
    {
        /// <summary>
        /// 默认品牌触发词
        /// </summary>
        [XmlArray("default_keywords")]
        [XmlArrayItem("string")]
        public List<string> DefaultKeywords { get; set; }

        /// <summary>
        /// 自定义品牌触发词
        /// </summary>
        [XmlArray("keywords")]
        [XmlArrayItem("string")]
        public List<string> Keywords { get; set; }
    }
}
