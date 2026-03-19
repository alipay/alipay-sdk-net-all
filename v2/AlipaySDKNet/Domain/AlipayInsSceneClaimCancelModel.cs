using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneClaimCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneClaimCancelModel : AopObject
    {
        /// <summary>
        /// 销案原因,业务自定义输入,无需枚举
        /// </summary>
        [XmlElement("cancel_reason")]
        public string CancelReason { get; set; }

        /// <summary>
        /// 蚂蚁返回的报案单号
        /// </summary>
        [XmlElement("claim_report_no")]
        public string ClaimReportNo { get; set; }

        /// <summary>
        /// 外部订单id,业务自行传入
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 约定的合作商id
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }
    }
}
