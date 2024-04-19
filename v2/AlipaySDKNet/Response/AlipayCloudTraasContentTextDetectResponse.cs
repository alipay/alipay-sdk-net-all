using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudTraasContentTextDetectResponse.
    /// </summary>
    public class AlipayCloudTraasContentTextDetectResponse : AopResponse
    {
        /// <summary>
        /// 唯一请求ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 风险识别标签内容
        /// </summary>
        [XmlArray("risk_check_labels")]
        [XmlArrayItem("risk_check_label")]
        public List<RiskCheckLabel> RiskCheckLabels { get; set; }

        /// <summary>
        /// 处置建议 枚举值 pass: pass block: block review: review
        /// </summary>
        [XmlElement("suggestion")]
        public string Suggestion { get; set; }

        /// <summary>
        /// 是否同步返回
        /// </summary>
        [XmlElement("sync")]
        public bool Sync { get; set; }
    }
}
