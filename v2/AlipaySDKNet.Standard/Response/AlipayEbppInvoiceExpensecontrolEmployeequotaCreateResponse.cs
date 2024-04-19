using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceExpensecontrolEmployeequotaCreateResponse.
    /// </summary>
    public class AlipayEbppInvoiceExpensecontrolEmployeequotaCreateResponse : AopResponse
    {
        /// <summary>
        /// 新增的余额ID
        /// </summary>
        [XmlElement("quota_id")]
        public string QuotaId { get; set; }
    }
}
