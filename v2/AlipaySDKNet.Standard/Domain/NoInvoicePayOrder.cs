using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NoInvoicePayOrder Data Structure.
    /// </summary>
    [Serializable]
    public class NoInvoicePayOrder : AopObject
    {
        /// <summary>
        /// 账单单据号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// PID
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 当前操作人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }
    }
}
