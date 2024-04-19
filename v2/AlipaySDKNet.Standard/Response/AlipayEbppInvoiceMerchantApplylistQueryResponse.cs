using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceMerchantApplylistQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceMerchantApplylistQueryResponse : AopResponse
    {
        /// <summary>
        /// 开票申请列表
        /// </summary>
        [XmlArray("invoice_apply_list")]
        [XmlArrayItem("invoice_apply_d_t_o")]
        public List<InvoiceApplyDTO> InvoiceApplyList { get; set; }
    }
}
