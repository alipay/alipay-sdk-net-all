using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceItaskOutorderForwardFinishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceItaskOutorderForwardFinishModel : AopObject
    {
        /// <summary>
        /// 机构正向工单结果回收对象
        /// </summary>
        [XmlElement("forward_feedback_order_request")]
        public ForwardFeedbackOrderRequest ForwardFeedbackOrderRequest { get; set; }
    }
}
