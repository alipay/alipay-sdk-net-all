using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAtechspayToolQueryResponse.
    /// </summary>
    public class AlipayOpenAtechspayToolQueryResponse : AopResponse
    {
        /// <summary>
        /// 诊断详情
        /// </summary>
        [XmlElement("diagnosis_info")]
        public ToolDatas DiagnosisInfo { get; set; }

        /// <summary>
        /// 诊断环境
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }

        /// <summary>
        /// 使用的工具标识
        /// </summary>
        [XmlElement("tool")]
        public string Tool { get; set; }
    }
}
