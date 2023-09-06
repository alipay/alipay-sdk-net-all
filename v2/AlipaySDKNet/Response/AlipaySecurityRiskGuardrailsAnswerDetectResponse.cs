using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskGuardrailsAnswerDetectResponse.
    /// </summary>
    public class AlipaySecurityRiskGuardrailsAnswerDetectResponse : AopResponse
    {
        /// <summary>
        /// 风险识别标签内容
        /// </summary>
        [XmlArray("detect_check_labels")]
        [XmlArrayItem("string")]
        public List<string> DetectCheckLabels { get; set; }

        /// <summary>
        /// 检测数据ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 处置建议：pass、review、block
        /// </summary>
        [XmlElement("suggestion")]
        public string Suggestion { get; set; }
    }
}
