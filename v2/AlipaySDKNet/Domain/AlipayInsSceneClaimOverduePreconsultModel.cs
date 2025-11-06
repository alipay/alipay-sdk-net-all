using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneClaimOverduePreconsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneClaimOverduePreconsultModel : AopObject
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("biz_data")]
        public InsClaimOverdueBizData BizData { get; set; }

        /// <summary>
        /// 赔案号
        /// </summary>
        [XmlElement("claim_no")]
        public string ClaimNo { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 合作商id
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 产品方案id
        /// </summary>
        [XmlElement("product_plan_id")]
        public string ProductPlanId { get; set; }
    }
}
