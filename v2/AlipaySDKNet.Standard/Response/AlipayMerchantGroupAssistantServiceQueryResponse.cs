using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupAssistantServiceQueryResponse.
    /// </summary>
    public class AlipayMerchantGroupAssistantServiceQueryResponse : AopResponse
    {
        /// <summary>
        /// 小助手快捷服务详情
        /// </summary>
        [XmlElement("assistant_detail")]
        public ServiceAssistantDetailVO AssistantDetail { get; set; }
    }
}
