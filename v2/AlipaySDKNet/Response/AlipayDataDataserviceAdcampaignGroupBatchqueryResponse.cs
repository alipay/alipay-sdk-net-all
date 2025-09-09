using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignGroupBatchqueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdcampaignGroupBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 单元列表数据对象
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("group_page_list_res")]
        public List<GroupPageListRes> List { get; set; }

        /// <summary>
        /// 分页信息
        /// </summary>
        [XmlElement("pagination")]
        public AdCamPagination Pagination { get; set; }
    }
}
