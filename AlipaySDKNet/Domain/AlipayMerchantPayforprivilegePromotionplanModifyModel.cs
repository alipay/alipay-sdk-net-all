using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantPayforprivilegePromotionplanModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantPayforprivilegePromotionplanModifyModel : AopObject
    {
        /// <summary>
        /// 充享惠方案的结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 充享惠方案ID，通过创建接口创建的ID
        /// </summary>
        [XmlElement("promotion_plan_id")]
        public string PromotionPlanId { get; set; }

        /// <summary>
        /// 充享惠方案开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 充享惠方案的状态，ENABLED(启用), DISABLED(停用)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
