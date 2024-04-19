using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseMonitorWebhookbindDeleteResponse.
    /// </summary>
    public class AlipayCloudCloudbaseMonitorWebhookbindDeleteResponse : AopResponse
    {
        /// <summary>
        /// 删除结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
