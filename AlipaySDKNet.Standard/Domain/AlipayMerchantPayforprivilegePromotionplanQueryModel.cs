using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantPayforprivilegePromotionplanQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantPayforprivilegePromotionplanQueryModel : AopObject
    {
        /// <summary>
        /// 充享惠方案ID
        /// </summary>
        [XmlElement("promotion_plan_id")]
        public string PromotionPlanId { get; set; }
    }
}
