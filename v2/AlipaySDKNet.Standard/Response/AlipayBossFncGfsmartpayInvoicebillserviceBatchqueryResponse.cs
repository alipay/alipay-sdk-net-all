using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncGfsmartpayInvoicebillserviceBatchqueryResponse.
    /// </summary>
    public class AlipayBossFncGfsmartpayInvoicebillserviceBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 开票账单信息通用结果模型
        /// </summary>
        [XmlElement("result_set")]
        public ResponseModelForInvoiceBillDTO ResultSet { get; set; }
    }
}
