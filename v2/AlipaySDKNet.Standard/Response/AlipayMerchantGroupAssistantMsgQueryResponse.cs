using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupAssistantMsgQueryResponse.
    /// </summary>
    public class AlipayMerchantGroupAssistantMsgQueryResponse : AopResponse
    {
        /// <summary>
        /// 商家群定向消息详情
        /// </summary>
        [XmlElement("msg_detail")]
        public AssistantMsgDetailVO MsgDetail { get; set; }
    }
}
