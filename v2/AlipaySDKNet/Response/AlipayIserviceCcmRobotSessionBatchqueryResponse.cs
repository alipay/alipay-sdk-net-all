using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmRobotSessionBatchqueryResponse.
    /// </summary>
    public class AlipayIserviceCcmRobotSessionBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 会话列表分页数据
        /// </summary>
        [XmlElement("data")]
        public FcStarRobotSessionPage Data { get; set; }
    }
}
