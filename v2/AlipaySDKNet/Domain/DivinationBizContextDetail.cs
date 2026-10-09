using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DivinationBizContextDetail Data Structure.
    /// </summary>
    [Serializable]
    public class DivinationBizContextDetail : AopObject
    {
        /// <summary>
        /// 签文类别
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 签语
        /// </summary>
        [XmlElement("conclusion")]
        public string Conclusion { get; set; }

        /// <summary>
        /// 求签ID，由提供方生成
        /// </summary>
        [XmlElement("divination_id")]
        public string DivinationId { get; set; }

        /// <summary>
        /// 签文等级
        /// </summary>
        [XmlElement("grade")]
        public string Grade { get; set; }

        /// <summary>
        /// 仙机
        /// </summary>
        [XmlElement("insight")]
        public string Insight { get; set; }

        /// <summary>
        /// 签文解释解曰
        /// </summary>
        [XmlElement("interpretation")]
        public string Interpretation { get; set; }

        /// <summary>
        /// 签文名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 签文内容诗曰，一般是四句话
        /// </summary>
        [XmlElement("poem")]
        public string Poem { get; set; }

        /// <summary>
        /// 引用的古人典故
        /// </summary>
        [XmlElement("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// 序列号
        /// </summary>
        [XmlElement("sequence_number")]
        public string SequenceNumber { get; set; }
    }
}
