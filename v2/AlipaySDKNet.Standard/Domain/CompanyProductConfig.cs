using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CompanyProductConfig Data Structure.
    /// </summary>
    [Serializable]
    public class CompanyProductConfig : AopObject
    {
        /// <summary>
        /// 票种
        /// </summary>
        [XmlElement("invoice_kind")]
        public string InvoiceKind { get; set; }

        /// <summary>
        /// 启用订单审核
        /// </summary>
        [XmlElement("order_audit")]
        public string OrderAudit { get; set; }

        /// <summary>
        /// 计税方式
        /// </summary>
        [XmlElement("tax_method")]
        public string TaxMethod { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }
    }
}
