using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RuleDefine Data Structure.
    /// </summary>
    [Serializable]
    public class RuleDefine : AopObject
    {
        /// <summary>
        /// bizTid范围
        /// </summary>
        [XmlArray("biz_tids")]
        [XmlArrayItem("string")]
        public List<string> BizTids { get; set; }

        /// <summary>
        /// 实体条件
        /// </summary>
        [XmlElement("entity_condition")]
        public string EntityCondition { get; set; }

        /// <summary>
        /// 实体值
        /// </summary>
        [XmlArray("entity_values")]
        [XmlArrayItem("string")]
        public List<string> EntityValues { get; set; }
    }
}
