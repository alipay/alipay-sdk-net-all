using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettleprodNoinvoicePayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsettleprodNoinvoicePayModel : AopObject
    {
        /// <summary>
        /// 无票付款
        /// </summary>
        [XmlElement("no_invoice_pay_order")]
        public NoInvoicePayOrder NoInvoicePayOrder { get; set; }
    }
}
