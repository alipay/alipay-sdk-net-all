using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAntbookcontentBookQueryResponse.
    /// </summary>
    public class AlipayUserAntbookcontentBookQueryResponse : AopResponse
    {
        /// <summary>
        /// 书籍信息列表
        /// </summary>
        [XmlArray("book_info_list")]
        [XmlArrayItem("book_info")]
        public List<BookInfo> BookInfoList { get; set; }

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
        /// 书籍总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
