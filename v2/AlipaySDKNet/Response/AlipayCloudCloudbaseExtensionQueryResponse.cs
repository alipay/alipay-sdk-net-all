using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseExtensionQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseExtensionQueryResponse : AopResponse
    {
        /// <summary>
        /// 扩展列表信息
        /// </summary>
        [XmlArray("extensions")]
        [XmlArrayItem("extension")]
        public List<Extension> Extensions { get; set; }

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
        public string Total { get; set; }
    }
}
