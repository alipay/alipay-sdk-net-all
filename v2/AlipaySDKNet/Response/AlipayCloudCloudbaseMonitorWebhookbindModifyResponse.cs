using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseMonitorWebhookbindModifyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseMonitorWebhookbindModifyResponse : AopResponse
    {
        /// <summary>
        /// 更新结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
