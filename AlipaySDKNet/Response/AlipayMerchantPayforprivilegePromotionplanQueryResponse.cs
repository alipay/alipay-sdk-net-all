using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegePromotionplanQueryResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegePromotionplanQueryResponse : AopResponse
    {
        /// <summary>
        /// 充享惠方案信息，返回之前创建的充享惠方案信息，方案不存在或者无权限返回空
        /// </summary>
        [XmlElement("promotion_plan")]
        public PayForPrivilegePromotionPlanInfo PromotionPlan { get; set; }
    }
}
