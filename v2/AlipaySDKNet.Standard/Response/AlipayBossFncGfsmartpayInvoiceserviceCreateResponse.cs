using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncGfsmartpayInvoiceserviceCreateResponse.
    /// </summary>
    public class AlipayBossFncGfsmartpayInvoiceserviceCreateResponse : AopResponse
    {
        /// <summary>
        /// 通用返回结果
        /// </summary>
        [XmlElement("result_set")]
        public ResponseModelForInvoiceBill ResultSet { get; set; }
    }
}
