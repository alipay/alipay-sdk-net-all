using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppServiceValidpageQueryResponse.
    /// </summary>
    public class AlipayOpenAppServiceValidpageQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 每页显示多少条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 服务基础信息
        /// </summary>
        [XmlArray("service_list")]
        [XmlArrayItem("service_base")]
        public List<ServiceBase> ServiceList { get; set; }

        /// <summary>
        /// 记录总条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
