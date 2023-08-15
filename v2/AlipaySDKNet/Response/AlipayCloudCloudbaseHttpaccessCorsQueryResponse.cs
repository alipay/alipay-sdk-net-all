using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseHttpaccessCorsQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseHttpaccessCorsQueryResponse : AopResponse
    {
        /// <summary>
        /// 跨域安全域名列表
        /// </summary>
        [XmlArray("cors")]
        [XmlArrayItem("faas_cors")]
        public List<FaasCors> Cors { get; set; }

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
    }
}
