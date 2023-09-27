using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseAntifloodSwitchGetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseAntifloodSwitchGetResponse : AopResponse
    {
        /// <summary>
        /// 防刷开关状态
        /// </summary>
        [XmlElement("enabled")]
        public bool Enabled { get; set; }
    }
}
