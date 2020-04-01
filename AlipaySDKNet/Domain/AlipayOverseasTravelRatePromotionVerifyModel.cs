using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTravelRatePromotionVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelRatePromotionVerifyModel : AopObject
    {
        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [XmlElement("extend_param")]
        public string ExtendParam { get; set; }

        /// <summary>
        /// 跨境游发现平台优惠id
        /// </summary>
        [XmlElement("travel_promotion_id")]
        public string TravelPromotionId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
