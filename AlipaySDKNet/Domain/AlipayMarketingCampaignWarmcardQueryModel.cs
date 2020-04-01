using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignWarmcardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignWarmcardQueryModel : AopObject
    {
        /// <summary>
        /// 春暖花开活动场景码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
