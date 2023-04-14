using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignApproveOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SignApproveOpenApiDTO : AopObject
    {
        /// <summary>
        /// 审批流id列表
        /// </summary>
        [XmlArray("process_ids")]
        [XmlArrayItem("string")]
        public List<string> ProcessIds { get; set; }

        /// <summary>
        /// 审批类型
        /// </summary>
        [XmlElement("process_type")]
        public string ProcessType { get; set; }
    }
}
