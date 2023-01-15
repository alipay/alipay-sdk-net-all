using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OutputApplyInvoiceDetailOrder Data Structure.
    /// </summary>
    [Serializable]
    public class OutputApplyInvoiceDetailOrder : AopObject
    {
        /// <summary>
        /// 分配多少金额到本组对象
        /// </summary>
        [XmlElement("target_invoice_amt")]
        public MultiCurrencyMoneyOpenApi TargetInvoiceAmt { get; set; }

        /// <summary>
        /// 打印到发票上面的备注
        /// </summary>
        [XmlElement("target_invoice_note")]
        public string TargetInvoiceNote { get; set; }

        /// <summary>
        /// 目标ipRoleId
        /// </summary>
        [XmlElement("target_ip_role_id")]
        public string TargetIpRoleId { get; set; }
    }
}
