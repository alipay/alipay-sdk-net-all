using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceRegisterCreateResponse.
    /// </summary>
    public class AlipayEbppInvoiceRegisterCreateResponse : AopResponse
    {
        /// <summary>
        /// 入驻工单ID，发票中台生成
        /// </summary>
        [XmlElement("register_id")]
        public string RegisterId { get; set; }
    }
}
