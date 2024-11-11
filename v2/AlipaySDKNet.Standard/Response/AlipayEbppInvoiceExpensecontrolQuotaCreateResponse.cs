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
        /// 发放批次id
        /// </summary>
        [XmlElement("issue_batch_id")]
        public string IssueBatchId { get; set; }

        /// <summary>
        /// 创建的额度ID
        /// </summary>
        [XmlElement("quota_id")]
        public string QuotaId { get; set; }
    }
}
