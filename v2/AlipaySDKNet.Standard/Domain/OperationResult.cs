using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OperationResult Data Structure.
    /// </summary>
    [Serializable]
    public class OperationResult : AopObject
    {
        /// <summary>
        /// 失败的数量
        /// </summary>
        [XmlElement("failure_count")]
        public long FailureCount { get; set; }

        /// <summary>
        /// 存储失败的IDs
        /// </summary>
        [XmlArray("failure_ids")]
        [XmlArrayItem("string")]
        public List<string> FailureIds { get; set; }

        /// <summary>
        /// 成功的数量
        /// </summary>
        [XmlElement("success_count")]
        public long SuccessCount { get; set; }

        /// <summary>
        /// 存储成功的IDs
        /// </summary>
        [XmlArray("success_ids")]
        [XmlArrayItem("string")]
        public List<string> SuccessIds { get; set; }
    }
}
