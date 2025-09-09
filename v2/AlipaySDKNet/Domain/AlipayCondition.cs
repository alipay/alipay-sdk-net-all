using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCondition Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCondition : AopObject
    {
        /// <summary>
        /// 字段编码,查询条件的目标字段名
        /// </summary>
        [XmlElement("field_code")]
        public string FieldCode { get; set; }

        /// <summary>
        /// field_operator_type可选类型：  LARGE("large", "大于" , "rangeQuery"),  LESS("less", "小于" , "rangeQuery"),  BETWEEN("between", "在范围内，前包含后包含" , "rangeQuery"),  IN("in", "在离散列表中" , "matchPhraseQuery"),  EQUAL("equal", "等于" , "termQuery"),  LIKE("like", "类似" , "matchPhraseQuery"),  PREFIX_LIKE("prefix_like", "前缀匹配" , "prefixLike"),  WORD_LIKE("word_like", "分词相似" , "matchQuery")
        /// </summary>
        [XmlElement("field_operator_type")]
        public string FieldOperatorType { get; set; }

        /// <summary>
        /// 目标字段的值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
