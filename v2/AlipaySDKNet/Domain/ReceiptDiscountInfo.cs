using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReceiptDiscountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ReceiptDiscountInfo : AopObject
    {
        /// <summary>
        /// 优惠金额，单位分
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 优惠描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }
    }
}
