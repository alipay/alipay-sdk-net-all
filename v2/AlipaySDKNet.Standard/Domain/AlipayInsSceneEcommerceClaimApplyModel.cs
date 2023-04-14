using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneEcommerceClaimApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneEcommerceClaimApplyModel : AopObject
    {
        /// <summary>
        /// 申请报案金额（单位：分）
        /// </summary>
        [XmlElement("apply_amout")]
        public long ApplyAmout { get; set; }

        /// <summary>
        /// 报案材料
        /// </summary>
        [XmlArray("attachments")]
        [XmlArrayItem("ins_open_attachment_d_t_o")]
        public List<InsOpenAttachmentDTO> Attachments { get; set; }

        /// <summary>
        /// 买家
        /// </summary>
        [XmlElement("buyer")]
        public EcomBuyerDTO Buyer { get; set; }

        /// <summary>
        /// 商品
        /// </summary>
        [XmlElement("item")]
        public EcomItemDTO Item { get; set; }

        /// <summary>
        /// 订单
        /// </summary>
        [XmlElement("order_dto")]
        public EcomOrderDTO OrderDto { get; set; }

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

        /// <summary>
        /// 逆向纠纷单
        /// </summary>
        [XmlElement("refund_dispute")]
        public EcomRefundDisputeDTO RefundDispute { get; set; }

        /// <summary>
        /// 报案业务单号（用于幂等）
        /// </summary>
        [XmlElement("report_out_biz_no")]
        public string ReportOutBizNo { get; set; }

        /// <summary>
        /// 卖家
        /// </summary>
        [XmlElement("seller")]
        public EcomSellerDTO Seller { get; set; }
    }
}
