using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneClaimAdvancepaySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneClaimAdvancepaySyncModel : AopObject
    {
        /// <summary>
        /// 垫付信息
        /// </summary>
        [XmlElement("advance_payment")]
        public ClaimAdvancePaymentDTO AdvancePayment { get; set; }

        /// <summary>
        /// 报案单号
        /// </summary>
        [XmlElement("claim_report_no")]
        public string ClaimReportNo { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 合作商标识
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }
    }
}
