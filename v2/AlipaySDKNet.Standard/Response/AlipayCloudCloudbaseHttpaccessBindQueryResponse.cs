using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseHttpaccessBindQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseHttpaccessBindQueryResponse : AopResponse
    {
        /// <summary>
        /// 路由绑定列表
        /// </summary>
        [XmlArray("domain_binds")]
        [XmlArrayItem("domain_bind")]
        public List<DomainBind> DomainBinds { get; set; }

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
