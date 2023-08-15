using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignDiscountInfoQueryModel : AopObject
    {
        /// <summary>
        /// 立减活动Id
        /// </summary>
        [XmlElement("discount_id")]
        public string DiscountId { get; set; }
    }
}
