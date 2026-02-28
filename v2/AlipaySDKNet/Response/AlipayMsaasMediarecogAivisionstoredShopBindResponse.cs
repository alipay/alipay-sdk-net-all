using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogAivisionstoredShopBindResponse.
    /// </summary>
    public class AlipayMsaasMediarecogAivisionstoredShopBindResponse : AopResponse
    {
        /// <summary>
        /// AI激活状态
        /// </summary>
        [XmlElement("ai_service_status")]
        public string AiServiceStatus { get; set; }
    }
}
