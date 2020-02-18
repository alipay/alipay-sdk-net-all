using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceDeployorderResultSendResponse.
    /// </summary>
    public class AlipayDataDataserviceDeployorderResultSendResponse : AopResponse
    {
        /// <summary>
        /// 处理是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
