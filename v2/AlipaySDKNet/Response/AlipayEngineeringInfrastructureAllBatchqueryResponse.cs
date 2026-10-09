using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEngineeringInfrastructureAllBatchqueryResponse.
    /// </summary>
    public class AlipayEngineeringInfrastructureAllBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 反馈内容
        /// </summary>
        [XmlArray("user_feedback_list")]
        [XmlArrayItem("user_feedback_result")]
        public List<UserFeedbackResult> UserFeedbackList { get; set; }
    }
}
