using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceOperateParam Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceOperateParam : AopObject
    {
        /// <summary>
        /// 发票ID
        /// </summary>
        [XmlElement("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// INVALID-发票作废
        /// </summary>
        [XmlElement("operator_type")]
        public string OperatorType { get; set; }
    }
}
