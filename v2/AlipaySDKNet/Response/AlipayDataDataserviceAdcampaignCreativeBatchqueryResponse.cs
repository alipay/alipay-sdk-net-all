using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignCreativeBatchqueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdcampaignCreativeBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 创意分页数据
        /// </summary>
        [XmlArray("content_list")]
        [XmlArrayItem("creative_page_list_res")]
        public List<CreativePageListRes> ContentList { get; set; }

        /// <summary>
        /// 分页数据
        /// </summary>
        [XmlElement("list")]
        public CreativePageListRes List { get; set; }

        /// <summary>
        /// 分页信息
        /// </summary>
        [XmlElement("pagination")]
        public AdCamPagination Pagination { get; set; }
    }
}
