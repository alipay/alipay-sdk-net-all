using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseHttpaccessDomainQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseHttpaccessDomainQueryResponse : AopResponse
    {
        /// <summary>
        /// 域信息列表
        /// </summary>
        [XmlArray("cloud_domains")]
        [XmlArrayItem("faas_cloud_domains")]
        public List<FaasCloudDomains> CloudDomains { get; set; }

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
