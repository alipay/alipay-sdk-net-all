using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniResourceQueryResponse.
    /// </summary>
    public class AlipayOpenMiniResourceQueryResponse : AopResponse
    {
        /// <summary>
        /// 数据结果 如果为空, 网关会不透出这个字段
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("query_mini_resource_response")]
        public List<QueryMiniResourceResponse> DataList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 数据总量
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
