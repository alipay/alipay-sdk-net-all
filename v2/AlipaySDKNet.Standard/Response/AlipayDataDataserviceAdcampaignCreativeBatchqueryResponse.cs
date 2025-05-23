using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignCreativeBatchqueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdcampaignCreativeBatchqueryResponse : AopResponse
    {
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
