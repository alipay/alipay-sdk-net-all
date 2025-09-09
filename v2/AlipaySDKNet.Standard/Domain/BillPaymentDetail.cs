using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BillPaymentDetail Data Structure.
    /// </summary>
    [Serializable]
    public class BillPaymentDetail : AopObject
    {
        /// <summary>
        /// 缴费项ID
        /// </summary>
        [XmlElement("bill_payment_id")]
        public string BillPaymentId { get; set; }
    }
}
