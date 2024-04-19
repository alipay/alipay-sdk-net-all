using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodContractCheckavailableResponse.
    /// </summary>
    public class AlipayInsSceneInsserviceprodContractCheckavailableResponse : AopResponse
    {
        /// <summary>
        /// INIT：未生效 FINISHED：服务已完结，无法提供服务 EFFECTIVE：生效中，可以提供服务 RELEASED：服务已解约，无法提供服务 CLOSED：已关闭
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
