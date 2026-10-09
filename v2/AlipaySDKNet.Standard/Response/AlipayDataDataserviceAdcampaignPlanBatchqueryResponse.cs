using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignPlanBatchqueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdcampaignPlanBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 计划分页数据信息
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("plan_page_list_res")]
        public List<PlanPageListRes> List { get; set; }

        /// <summary>
        /// 分页信息
        /// </summary>
        [XmlElement("pagination")]
        public AdCamPagination Pagination { get; set; }
    }
}
