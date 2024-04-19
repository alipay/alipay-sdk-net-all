using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseMonitorWebhookbindQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseMonitorWebhookbindQueryResponse : AopResponse
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }

        /// <summary>
        /// webhook 绑定信息
        /// </summary>
        [XmlArray("webhook_binds")]
        [XmlArrayItem("webhook_bind")]
        public List<WebhookBind> WebhookBinds { get; set; }
    }
}
