using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Precondition Data Structure.
    /// </summary>
    [Serializable]
    public class Precondition : AopObject
    {
        /// <summary>
        /// 等价关系
        /// </summary>
        [XmlElement("equivalent_relation")]
        public string EquivalentRelation { get; set; }

        /// <summary>
        /// 入参
        /// </summary>
        [XmlElement("input_param")]
        public string InputParam { get; set; }

        /// <summary>
        /// 出参
        /// </summary>
        [XmlElement("output_param")]
        public string OutputParam { get; set; }
    }
}
