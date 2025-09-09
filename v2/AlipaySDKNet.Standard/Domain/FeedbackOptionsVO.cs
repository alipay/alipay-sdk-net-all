using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FeedbackOptionsVO Data Structure.
    /// </summary>
    [Serializable]
    public class FeedbackOptionsVO : AopObject
    {
        /// <summary>
        /// 一级选项名称
        /// </summary>
        [XmlElement("primary_class")]
        public string PrimaryClass { get; set; }

        /// <summary>
        /// 一级分类名称
        /// </summary>
        [XmlElement("primary_class_code")]
        public string PrimaryClassCode { get; set; }

        /// <summary>
        /// 子选择
        /// </summary>
        [XmlArray("suboption")]
        [XmlArrayItem("feedback_suboption")]
        public List<FeedbackSuboption> Suboption { get; set; }
    }
}
