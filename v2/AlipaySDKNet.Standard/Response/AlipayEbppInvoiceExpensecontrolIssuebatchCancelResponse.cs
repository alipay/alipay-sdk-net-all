using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceExpensecontrolIssuebatchCancelResponse.
    /// </summary>
    public class AlipayEbppInvoiceExpensecontrolIssuebatchCancelResponse : AopResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
