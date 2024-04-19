using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEngineeringInfrastructureAnttestopsTestcaseTriggerResponse.
    /// </summary>
    public class AlipayEngineeringInfrastructureAnttestopsTestcaseTriggerResponse : AopResponse
    {
        /// <summary>
        /// 用例执行结果primaryid
        /// </summary>
        [XmlElement("case_execute_result_id")]
        public long CaseExecuteResultId { get; set; }
    }
}
