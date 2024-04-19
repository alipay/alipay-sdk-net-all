using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseMonitorWebhookbindDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseMonitorWebhookbindDeleteModel : AopObject
    {
        /// <summary>
        /// 绑定id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
