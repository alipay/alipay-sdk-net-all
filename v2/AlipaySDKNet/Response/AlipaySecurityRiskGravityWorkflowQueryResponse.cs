using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskGravityWorkflowQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskGravityWorkflowQueryResponse : AopResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("code_error")]
        public string CodeError { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("code_message")]
        public string CodeMessage { get; set; }

        /// <summary>
        /// 最后操作的状态：如同意或拒绝
        /// </summary>
        [XmlElement("last_operate")]
        public string LastOperate { get; set; }

        /// <summary>
        /// 出来结果
        /// </summary>
        [XmlElement("process_success")]
        public bool ProcessSuccess { get; set; }

        /// <summary>
        /// 流程状态
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }
    }
}
