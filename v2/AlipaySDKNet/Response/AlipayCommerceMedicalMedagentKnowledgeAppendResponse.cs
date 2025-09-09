using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMedagentKnowledgeAppendResponse.
    /// </summary>
    public class AlipayCommerceMedicalMedagentKnowledgeAppendResponse : AopResponse
    {
        /// <summary>
        /// 操作结果
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("operation_result")]
        public List<OperationResult> Data { get; set; }
    }
}
