using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentItems Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentItems : AopObject
    {
        /// <summary>
        /// is goods allowed partial payment
        /// </summary>
        [XmlElement("allowd_partial_payment")]
        public string AllowdPartialPayment { get; set; }

        /// <summary>
        /// The date and time when payment expires
        /// </summary>
        [XmlElement("payment_item_end_time")]
        public string PaymentItemEndTime { get; set; }

        /// <summary>
        /// unique id of payment item
        /// </summary>
        [XmlElement("payment_item_id")]
        public string PaymentItemId { get; set; }

        /// <summary>
        /// payment item local name
        /// </summary>
        [XmlElement("payment_item_local_name")]
        public string PaymentItemLocalName { get; set; }

        /// <summary>
        /// payment item name
        /// </summary>
        [XmlElement("payment_item_name")]
        public string PaymentItemName { get; set; }

        /// <summary>
        /// The date and time when payment is effective
        /// </summary>
        [XmlElement("payment_start_time")]
        public string PaymentStartTime { get; set; }

        /// <summary>
        /// payment item amount
        /// </summary>
        [XmlElement("payment_total_amount")]
        public TuitionMoneyDTO PaymentTotalAmount { get; set; }
    }
}
