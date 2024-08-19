using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SuggestQuestionsDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SuggestQuestionsDTO : AopObject
    {
        /// <summary>
        /// 推荐问题列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("string")]
        public List<string> List { get; set; }

        /// <summary>
        /// 推荐问题标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
