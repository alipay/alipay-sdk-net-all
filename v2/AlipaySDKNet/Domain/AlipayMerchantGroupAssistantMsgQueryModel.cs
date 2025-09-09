using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupAssistantMsgQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupAssistantMsgQueryModel : AopObject
    {
        /// <summary>
        /// 小助手内容id，创建定向消息时返回的数据唯一id
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }
    }
}
