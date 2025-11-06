using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneClaimOverdueCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneClaimOverdueCloseModel : AopObject
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
        /// 合作商id
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 当前支付信息
        /// </summary>
        [XmlElement("pay_entry_dto")]
        public InsPayEntryDTO PayEntryDto { get; set; }

        /// <summary>
        /// 支付信息列表
        /// </summary>
        [XmlArray("pay_entry_dto_list")]
        [XmlArrayItem("ins_pay_entry_d_t_o")]
        public List<InsPayEntryDTO> PayEntryDtoList { get; set; }

        /// <summary>
        /// 保单号
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
