using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationTimescardAuthorityQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationTimescardAuthorityQueryResponse : AopResponse
    {
        /// <summary>
        /// 详情
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("authority_detail_response")]
        public List<AuthorityDetailResponse> DataList { get; set; }

        /// <summary>
        /// 返回list对应的页码, 从1开始
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 返回list对应的页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总共的查询页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// 总共的查询记录数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
