using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceBillTaxConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceBillTaxConfirmModel : AopObject
    {
        /// <summary>
        /// 账单结束时间，格式：yyyyMMdd
        /// </summary>
        [XmlElement("bill_end")]
        public string BillEnd { get; set; }

        /// <summary>
        /// 账单开始时间，格式：yyyyMMdd
        /// </summary>
        [XmlElement("bill_start")]
        public string BillStart { get; set; }

        /// <summary>
        /// 账单号，计税时传的tenant_bill_no字段
        /// </summary>
        [XmlElement("tenant_bill_no")]
        public string TenantBillNo { get; set; }

        /// <summary>
        /// 账单计税明细
        /// </summary>
        [XmlArray("user_bill_tax_details")]
        [XmlArrayItem("user_bill_tax_detail")]
        public List<UserBillTaxDetail> UserBillTaxDetails { get; set; }
    }
}
