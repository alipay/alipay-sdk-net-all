using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceTitleBatchqueryInnerResponse.
    /// </summary>
    public class AlipayEbppInvoiceTitleBatchqueryInnerResponse : AopResponse
    {
        /// <summary>
        /// 用户抬头列表（包括个人、单位抬头）
        /// </summary>
        [XmlArray("title_list")]
        [XmlArrayItem("invoice_title_model")]
        public List<InvoiceTitleModel> TitleList { get; set; }
    }
}
