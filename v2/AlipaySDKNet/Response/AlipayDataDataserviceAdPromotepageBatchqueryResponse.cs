using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdPromotepageBatchqueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdPromotepageBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 自建推广页详情列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("promote_page_detail")]
        public List<PromotePageDetail> List { get; set; }

        /// <summary>
        /// 分页参数之页数
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页参数之每页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 分页参数之总数据量
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
