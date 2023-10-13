using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncInputInvoiceCallbackResponse.
    /// </summary>
    public class AlipayBossFncInputInvoiceCallbackResponse : AopResponse
    {
        /// <summary>
        /// 请求结果
        /// </summary>
        [XmlElement("result_set")]
        public bool ResultSet { get; set; }
    }
}
