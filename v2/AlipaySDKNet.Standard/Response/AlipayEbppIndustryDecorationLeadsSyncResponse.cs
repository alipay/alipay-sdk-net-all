using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryDecorationLeadsSyncResponse.
    /// </summary>
    public class AlipayEbppIndustryDecorationLeadsSyncResponse : AopResponse
    {
        /// <summary>
        /// true已保存留资反馈；false未保存留资反馈
        /// </summary>
        [XmlElement("leads_feedback")]
        public bool LeadsFeedback { get; set; }
    }
}
