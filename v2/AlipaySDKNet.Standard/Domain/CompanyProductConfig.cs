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
        /// 字段为Y时，扫码关联的订单在自然人确认后，会邀约自然人成为供应商，前提自然人非当前企业的供应商 字段默认为N
        /// </summary>
        [XmlElement("invite_suppliers_after_order_confirm")]
        public string InviteSuppliersAfterOrderConfirm { get; set; }

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
