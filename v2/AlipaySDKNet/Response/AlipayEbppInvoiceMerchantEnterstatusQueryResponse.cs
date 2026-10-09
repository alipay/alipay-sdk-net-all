using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceMerchantEnterstatusQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceMerchantEnterstatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 工单状态，审核中：AUDITING，验收中：ACCEPTING，成功：SUCCESS，失败：FAIL
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
