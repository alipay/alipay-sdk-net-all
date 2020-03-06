using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantPayforprivilegePayCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantPayforprivilegePayCreateModel : AopObject
    {
        /// <summary>
        /// 该字段已废弃，请使用user_id字段查询
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 外部业务号，用于幂等控制一次充值行为
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 充享惠方案ID
        /// </summary>
        [XmlElement("promotion_plan_id")]
        public string PromotionPlanId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
