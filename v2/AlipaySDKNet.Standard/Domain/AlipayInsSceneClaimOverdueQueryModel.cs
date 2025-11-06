using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneClaimOverdueQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneClaimOverdueQueryModel : AopObject
    {
        /// <summary>
        /// 赔案单号
        /// </summary>
        [XmlElement("claim_no")]
        public string ClaimNo { get; set; }

        /// <summary>
        /// 外部订单单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 追偿单号
        /// </summary>
        [XmlElement("overdue_no")]
        public string OverdueNo { get; set; }

        /// <summary>
        /// 合作商标识
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }
    }
}
