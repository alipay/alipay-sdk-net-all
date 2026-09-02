using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HealthDiscountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class HealthDiscountInfo : AopObject
    {
        /// <summary>
        /// 营销折扣
        /// </summary>
        [XmlElement("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// 权益优惠类型
        /// </summary>
        [XmlElement("equity_discount_type")]
        public string EquityDiscountType { get; set; }
    }
}
