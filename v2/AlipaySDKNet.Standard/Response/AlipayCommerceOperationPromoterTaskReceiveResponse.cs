using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationPromoterTaskReceiveResponse.
    /// </summary>
    public class AlipayCommerceOperationPromoterTaskReceiveResponse : AopResponse
    {
        /// <summary>
        /// 积分领取结果
        /// </summary>
        [XmlElement("task_receive_result")]
        public TaskReceiveInfo TaskReceiveResult { get; set; }
    }
}
