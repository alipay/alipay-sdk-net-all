using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RpaCrawlerQueryCriteriaVO Data Structure.
    /// </summary>
    [Serializable]
    public class RpaCrawlerQueryCriteriaVO : AopObject
    {
        /// <summary>
        /// 比较符
        /// </summary>
        [XmlElement("comparison")]
        public string Comparison { get; set; }

        /// <summary>
        /// 查询字段
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// eq,gt,lt生效,查询值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }

        /// <summary>
        /// between类型生效,结束值
        /// </summary>
        [XmlElement("value_end")]
        public string ValueEnd { get; set; }

        /// <summary>
        /// between类型生效,起始值
        /// </summary>
        [XmlElement("value_start")]
        public string ValueStart { get; set; }

        /// <summary>
        /// 目标值
        /// </summary>
        [XmlElement("values")]
        public string Values { get; set; }
    }
}
