using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAgreementCyclepayauthplansModifyResponse.
    /// </summary>
    public class AlipayUserAgreementCyclepayauthplansModifyResponse : AopResponse
    {
        /// <summary>
        /// 执行扣款计划详情
        /// </summary>
        [XmlElement("execution_plans")]
        public ExecutionPlan ExecutionPlans { get; set; }
    }
}
