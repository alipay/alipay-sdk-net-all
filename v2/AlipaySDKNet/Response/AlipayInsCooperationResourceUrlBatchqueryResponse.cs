using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsCooperationResourceUrlBatchqueryResponse.
    /// </summary>
    public class AlipayInsCooperationResourceUrlBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 资源项列表
        /// </summary>
        [XmlArray("resource_items")]
        [XmlArrayItem("resource_related_item")]
        public List<ResourceRelatedItem> ResourceItems { get; set; }

        /// <summary>
        /// 响应时间
        /// </summary>
        [XmlElement("response_time")]
        public string ResponseTime { get; set; }

        /// <summary>
        /// 结果编码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [XmlElement("result_desc")]
        public string ResultDesc { get; set; }
    }
}
