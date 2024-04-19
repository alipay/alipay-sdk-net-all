using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceApplyStatusNotifyResponse.
    /// </summary>
    public class AlipayEbppInvoiceApplyStatusNotifyResponse : AopResponse
    {
        /// <summary>
        /// update_success=false时返回。 该申请下存在未归集成功的发票。即：attach_invoices 中携带的发票存在未回传成功的发票。 此时调用方，需先调用发票回传接口，完成发票回传。然后再重试此接口。
        /// </summary>
        [XmlArray("missing_invoices")]
        [XmlArrayItem("invoice_uk_d_t_o")]
        public List<InvoiceUkDTO> MissingInvoices { get; set; }

        /// <summary>
        /// 事务执行结果，true成功，false失败
        /// </summary>
        [XmlElement("update_success")]
        public bool UpdateSuccess { get; set; }
    }
}
