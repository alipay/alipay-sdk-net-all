using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppAppcontentInternalQueryResponse.
    /// </summary>
    public class AlipayOpenAppAppcontentInternalQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 分页条数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 服务列表
        /// </summary>
        [XmlArray("service_list")]
        [XmlArrayItem("service_info")]
        public List<ServiceInfo> ServiceList { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total")]
        public string Total { get; set; }
    }
}
