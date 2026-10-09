using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncInputInvoiceSyncResponse.
    /// </summary>
    public class AlipayBossFncInputInvoiceSyncResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result_set")]
        public SyncInvoiceResponse ResultSet { get; set; }
    }
}
