using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceMerchantApplyModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceMerchantApplyModifyModel : AopObject
    {
        /// <summary>
        /// 发票申请ID, 由支付宝发票平台生成，申请单唯一标识，接口幂等字段.
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 原因说明，申请失败时必填
        /// </summary>
        [XmlElement("apply_result_memo")]
        public string ApplyResultMemo { get; set; }

        /// <summary>
        /// 申请状态，可选值： apply_success: 申请受理成功 waiting_pull：待拉取  inv_success: 开票成功； inv_fail：开票失败
        /// </summary>
        [XmlElement("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 已开具成功的发票 申请状态为inv_success时必填
        /// </summary>
        [XmlArray("attach_invoices")]
        [XmlArrayItem("merchant_invoice_u_k_d_t_o")]
        public List<MerchantInvoiceUKDTO> AttachInvoices { get; set; }

        /// <summary>
        /// 批次id
        /// </summary>
        [XmlElement("batch_id")]
        public string BatchId { get; set; }
    }
}
