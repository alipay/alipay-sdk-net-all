using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoAichatHistoryQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoAichatHistoryQueryResponse : AopResponse
    {
        /// <summary>
        /// 历史对话详情
        /// </summary>
        [XmlElement("histories")]
        public ChatHistory Histories { get; set; }
    }
}
