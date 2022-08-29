using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceExpensecontrolQuotaCreateResponse.
    /// </summary>
    public class AlipayEbppInvoiceExpensecontrolQuotaCreateResponse : AopResponse
    {
        /// <summary>
        /// 新增的额度ID
        /// </summary>
        [XmlElement("quota_id")]
        public string QuotaId { get; set; }
    }
}
