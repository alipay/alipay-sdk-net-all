using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIotIntentQueryResponse.
    /// </summary>
    public class AlipayIserviceIotIntentQueryResponse : AopResponse
    {
        /// <summary>
        /// iot的响应类
        /// </summary>
        [XmlElement("iot_response")]
        public IntentQueryResponse IotResponse { get; set; }
    }
}
