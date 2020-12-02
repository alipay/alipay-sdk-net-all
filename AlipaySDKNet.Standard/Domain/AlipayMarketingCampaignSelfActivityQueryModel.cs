using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignSelfActivityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignSelfActivityQueryModel : AopObject
    {
        /// <summary>
        /// b.alipay.com 运营中心配置后台-活动详情-活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
