using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskEffectScope Data Structure.
    /// </summary>
    [Serializable]
    public class TaskEffectScope : AopObject
    {
        /// <summary>
        /// 生效域id
        /// </summary>
        [XmlElement("scope_id")]
        public string ScopeId { get; set; }

        /// <summary>
        /// 任务生效范围id列表
        /// </summary>
        [XmlArray("subject_list")]
        [XmlArrayItem("string")]
        public List<string> SubjectList { get; set; }

        /// <summary>
        /// 任务生效对象类型为：商户
        /// </summary>
        [XmlElement("subject_type")]
        public string SubjectType { get; set; }
    }
}
