using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncInputinvoiceDistributeCallbackResponse.
    /// </summary>
    public class AlipayBossFncInputinvoiceDistributeCallbackResponse : AopResponse
    {
        /// <summary>
        /// 回调结果
        /// </summary>
        [XmlElement("result_set")]
        public InputInvoiceResponse ResultSet { get; set; }
    }
}
