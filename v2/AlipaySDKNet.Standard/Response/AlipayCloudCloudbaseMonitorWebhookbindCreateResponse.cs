using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseMonitorWebhookbindCreateResponse.
    /// </summary>
    public class AlipayCloudCloudbaseMonitorWebhookbindCreateResponse : AopResponse
    {
        /// <summary>
        /// 绑定id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
