using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SummaryInvoiceBillOpenDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SummaryInvoiceBillOpenDTO : AopObject
    {
        /// <summary>
        /// 账单流水号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 账单持有人uid
        /// </summary>
        [XmlElement("buyer_user_id")]
        public string BuyerUserId { get; set; }
    }
}
