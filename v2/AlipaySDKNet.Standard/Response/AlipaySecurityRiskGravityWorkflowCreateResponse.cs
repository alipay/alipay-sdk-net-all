using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskGravityWorkflowCreateResponse.
    /// </summary>
    public class AlipaySecurityRiskGravityWorkflowCreateResponse : AopResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("code_error")]
        public string CodeError { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 处理结果
        /// </summary>
        [XmlElement("process_success")]
        public string ProcessSuccess { get; set; }

        /// <summary>
        /// 合规流程id
        /// </summary>
        [XmlElement("pu_id")]
        public string PuId { get; set; }
    }
}
