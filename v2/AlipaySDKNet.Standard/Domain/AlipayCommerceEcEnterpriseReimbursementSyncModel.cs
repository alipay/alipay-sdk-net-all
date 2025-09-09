using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseReimbursementSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEnterpriseReimbursementSyncModel : AopObject
    {
        /// <summary>
        /// 企业码场景中员工id
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 企业码场景中对应企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 报销发票列表，用于同步报销状态出现变化的发票列表数据
        /// </summary>
        [XmlArray("invoice_list")]
        [XmlArrayItem("reimburse_invoice")]
        public List<ReimburseInvoice> InvoiceList { get; set; }

        /// <summary>
        /// 报销状态
        /// </summary>
        [XmlElement("reimburse_status")]
        public string ReimburseStatus { get; set; }
    }
}
