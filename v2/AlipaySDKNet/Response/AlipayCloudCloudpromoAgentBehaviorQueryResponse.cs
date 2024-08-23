using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoAgentBehaviorQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoAgentBehaviorQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户偏好信息
        /// </summary>
        [XmlElement("behavior")]
        public string Behavior { get; set; }
    }
}
