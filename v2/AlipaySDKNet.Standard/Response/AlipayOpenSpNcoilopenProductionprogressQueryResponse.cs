using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNcoilopenProductionprogressQueryResponse.
    /// </summary>
    public class AlipayOpenSpNcoilopenProductionprogressQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 当前页具体数据
        /// </summary>
        [XmlArray("sale_order_list")]
        [XmlArrayItem("sale_order_open_api_res")]
        public List<SaleOrderOpenApiRes> SaleOrderList { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
