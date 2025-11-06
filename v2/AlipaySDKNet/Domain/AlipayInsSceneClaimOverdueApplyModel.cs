using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneClaimOverdueApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneClaimOverdueApplyModel : AopObject
    {
        /// <summary>
        /// 追偿业务扩展字段
        /// </summary>
        [XmlElement("biz_data")]
        public InsClaimOverdueBizData BizData { get; set; }

        /// <summary>
        /// 赔案单号（用于幂等控制）
        /// </summary>
        [XmlElement("claim_no")]
        public string ClaimNo { get; set; }

        /// <summary>
        /// 追偿支出账号
        /// </summary>
        [XmlElement("out_account_no")]
        public string OutAccountNo { get; set; }

        /// <summary>
        /// 外部订单单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 追偿金额（单位是分）
        /// </summary>
        [XmlElement("overdue_amount")]
        public long OverdueAmount { get; set; }

        /// <summary>
        /// 合作商标识
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 关联保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 产品方案id
        /// </summary>
        [XmlElement("product_plan_id")]
        public string ProductPlanId { get; set; }
    }
}
