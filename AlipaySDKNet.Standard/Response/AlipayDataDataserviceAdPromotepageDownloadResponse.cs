using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdPromotepageDownloadResponse.
    /// </summary>
    public class AlipayDataDataserviceAdPromotepageDownloadResponse : AopResponse
    {
        /// <summary>
        /// 转化事件ID
        /// </summary>
        [XmlElement("conversion_id")]
        public string ConversionId { get; set; }

        /// <summary>
        /// 留资属性实例数据列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("promote_page_data")]
        public List<PromotePageData> List { get; set; }

        /// <summary>
        /// 分页参数之页数，从1开始
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页参数之每页大小，最大1000
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
