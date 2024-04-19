using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseMonitorWebhookbindGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseMonitorWebhookbindGetModel : AopObject
    {
        /// <summary>
        /// 绑定id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
