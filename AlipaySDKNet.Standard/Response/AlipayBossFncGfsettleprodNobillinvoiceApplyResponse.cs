using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncGfsettleprodNobillinvoiceApplyResponse.
    /// </summary>
    public class AlipayBossFncGfsettleprodNobillinvoiceApplyResponse : AopResponse
    {
        /// <summary>
        /// 发票申请单的申请单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 流程平台的流程id
        /// </summary>
        [XmlElement("process_id")]
        public string ProcessId { get; set; }
    }
}
