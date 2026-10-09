using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupAssistantMsgCreateResponse.
    /// </summary>
    public class AlipayMerchantGroupAssistantMsgCreateResponse : AopResponse
    {
        /// <summary>
        /// 小助手消息内容id
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }
    }
}
