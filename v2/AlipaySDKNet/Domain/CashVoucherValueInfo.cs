using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CashVoucherValueInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CashVoucherValueInfo : AopObject
    {
        /// <summary>
        /// 代金券使用门槛金额。 比如满25元减5元代金券，门槛金额指的就是25元。
        /// </summary>
        [XmlElement("threshold_amount")]
        public string ThresholdAmount { get; set; }

        /// <summary>
        /// 代金券的价值
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
