using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceApplyDetail Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceApplyDetail : AopObject
    {
        /// <summary>
        /// 账单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 业务资金类型
        /// </summary>
        [XmlElement("biz_fund_type")]
        public string BizFundType { get; set; }

        /// <summary>
        /// 开票金额
        /// </summary>
        [XmlElement("invoice_amount")]
        public string InvoiceAmount { get; set; }
    }
}
