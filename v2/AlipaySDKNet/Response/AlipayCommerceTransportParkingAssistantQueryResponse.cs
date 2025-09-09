using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportParkingAssistantQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportParkingAssistantQueryResponse : AopResponse
    {
        /// <summary>
        /// 停车助手服务状态；开通服务：
        /// </summary>
        [XmlElement("assistant_service_status")]
        public string AssistantServiceStatus { get; set; }
    }
}
