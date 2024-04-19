using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreComplianceRcsmartQtdialogueCheckResponse.
    /// </summary>
    public class AlipayFincoreComplianceRcsmartQtdialogueCheckResponse : AopResponse
    {
        /// <summary>
        /// 对话审核结果
        /// </summary>
        [XmlElement("data")]
        public DialogueAuditResult Data { get; set; }
    }
}
