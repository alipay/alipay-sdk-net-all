using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndicatorData Data Structure.
    /// </summary>
    [Serializable]
    public class IndicatorData : AopObject
    {
        /// <summary>
        /// 绝对差结果
        /// </summary>
        [XmlElement("absolute")]
        public TestResult Absolute { get; set; }

        /// <summary>
        /// 49700049
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 指标名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 相对差结果
        /// </summary>
        [XmlElement("relative")]
        public TestResult Relative { get; set; }
    }
}
