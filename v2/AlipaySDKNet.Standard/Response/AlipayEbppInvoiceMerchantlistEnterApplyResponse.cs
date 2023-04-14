using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceMerchantlistEnterApplyResponse.
    /// </summary>
    public class AlipayEbppInvoiceMerchantlistEnterApplyResponse : AopResponse
    {
        /// <summary>
        /// 工单流水号，支付开票PID模式当前不会返回流水号。
        /// </summary>
        [XmlElement("process_id")]
        public string ProcessId { get; set; }
    }
}
