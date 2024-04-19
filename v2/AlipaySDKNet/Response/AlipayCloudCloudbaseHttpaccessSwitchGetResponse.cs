using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseHttpaccessSwitchGetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseHttpaccessSwitchGetResponse : AopResponse
    {
        /// <summary>
        /// HTTP访问开关状态
        /// </summary>
        [XmlElement("enabled")]
        public bool Enabled { get; set; }
    }
}
