using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoCityserviceExtCommentBatchqueryResponse.
    /// </summary>
    public class AlipayEcoCityserviceExtCommentBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 评价列表
        /// </summary>
        [XmlArray("comment_list")]
        [XmlArrayItem("cmt_content_back_flow")]
        public List<CmtContentBackFlow> CommentList { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 某appid下的订单评价数据总条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
