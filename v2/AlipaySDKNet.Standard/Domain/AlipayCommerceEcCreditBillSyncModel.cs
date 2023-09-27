using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcCreditBillSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcCreditBillSyncModel : AopObject
    {
        /// <summary>
        /// 账单月
        /// </summary>
        [XmlElement("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 还款日期，格式："yyyy-MM-dd"
        /// </summary>
        [XmlElement("repayment_date")]
        public string RepaymentDate { get; set; }
    }
}
