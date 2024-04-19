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
        /// 发票申请ID
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 申请失败原因说明
        /// </summary>
        [XmlElement("apply_result_memo")]
        public string ApplyResultMemo { get; set; }

        /// <summary>
        /// 申请状态
        /// </summary>
        [XmlElement("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 已开具成功的发票
        /// </summary>
        [XmlArray("attach_invoices")]
        [XmlArrayItem("merchant_invoice_u_k_d_t_o")]
        public List<MerchantInvoiceUKDTO> AttachInvoices { get; set; }

        /// <summary>
        /// 批次ID
        /// </summary>
        [XmlElement("batch_id")]
        public string BatchId { get; set; }
    }
}
