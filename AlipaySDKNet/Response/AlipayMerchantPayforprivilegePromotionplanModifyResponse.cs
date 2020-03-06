using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegePromotionplanModifyResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegePromotionplanModifyResponse : AopResponse
    {
        /// <summary>
        /// 充值方案信息，返回修改后的充值方案信息
        /// </summary>
        [XmlElement("promotion_plan")]
        public PayForPrivilegePromotionPlanInfo PromotionPlan { get; set; }
    }
}
