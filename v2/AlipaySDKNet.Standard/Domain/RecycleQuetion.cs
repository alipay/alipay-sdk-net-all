using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleQuetion Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleQuetion : AopObject
    {
        /// <summary>
        /// 问卷选项列表
        /// </summary>
        [XmlArray("options")]
        [XmlArrayItem("recycle_option")]
        public List<RecycleOption> Options { get; set; }

        /// <summary>
        /// 问题code
        /// </summary>
        [XmlElement("question_code")]
        public string QuestionCode { get; set; }

        /// <summary>
        /// 回收问卷名称
        /// </summary>
        [XmlElement("question_name")]
        public string QuestionName { get; set; }
    }
}
