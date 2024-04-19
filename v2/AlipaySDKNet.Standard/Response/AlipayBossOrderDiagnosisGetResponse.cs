using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossOrderDiagnosisGetResponse.
    /// </summary>
    public class AlipayBossOrderDiagnosisGetResponse : AopResponse
    {
        /// <summary>
        /// 诊断模型
        /// </summary>
        [XmlArray("diagnosis_result")]
        [XmlArrayItem("diagnosis_info")]
        public List<DiagnosisInfo> DiagnosisResult { get; set; }
    }
}
