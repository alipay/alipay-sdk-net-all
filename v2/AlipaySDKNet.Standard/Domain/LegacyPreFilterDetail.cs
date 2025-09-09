using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LegacyPreFilterDetail Data Structure.
    /// </summary>
    [Serializable]
    public class LegacyPreFilterDetail : AopObject
    {
        /// <summary>
        /// 各条检索条件之间的关系
        /// </summary>
        [XmlElement("expression_relationship")]
        public string ExpressionRelationship { get; set; }

        /// <summary>
        /// 检索字段之间的关系
        /// </summary>
        [XmlElement("relationship")]
        public string Relationship { get; set; }

        /// <summary>
        /// 被检索列名
        /// </summary>
        [XmlElement("retrieved_column_name")]
        public string RetrievedColumnName { get; set; }

        /// <summary>
        /// 筛选值配置
        /// </summary>
        [XmlElement("values")]
        public LegacyPreFilterValueDetail Values { get; set; }
    }
}
