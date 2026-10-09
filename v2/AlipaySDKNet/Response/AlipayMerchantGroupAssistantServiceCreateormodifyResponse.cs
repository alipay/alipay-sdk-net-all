using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupAssistantServiceCreateormodifyResponse.
    /// </summary>
    public class AlipayMerchantGroupAssistantServiceCreateormodifyResponse : AopResponse
    {
        /// <summary>
        /// 小助手内容id，创建快捷服务时返回的数据唯一id
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }
    }
}
