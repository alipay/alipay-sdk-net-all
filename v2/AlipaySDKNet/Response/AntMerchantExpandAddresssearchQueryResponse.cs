using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandAddresssearchQueryResponse.
    /// </summary>
    public class AntMerchantExpandAddresssearchQueryResponse : AopResponse
    {
        /// <summary>
        /// 经纬度,名称和地址以及省市区信息,是一个集合List
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("open_query_poim_base_response")]
        public List<OpenQueryPoimBaseResponse> Data { get; set; }

        /// <summary>
        /// 当前页码，默认第一页
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 表示返回记录总页面数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// 表示返回记录数总记录
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
