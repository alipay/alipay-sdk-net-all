using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignPrizepoolPrizeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignPrizepoolPrizeQueryModel : AopObject
    {
        /// <summary>
        /// 活动id,由蚂蚁营销产品统一分配
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 奖品池id,由蚂蚁营销产品统一分配
        /// </summary>
        [XmlElement("pool_id")]
        public string PoolId { get; set; }

        /// <summary>
        /// 奖品id
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }
    }
}
