using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChargerDiscountActivityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ChargerDiscountActivityInfo : AopObject
    {
        /// <summary>
        /// 满减金额，单位：元
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 门槛金额，单位：元
        /// </summary>
        [XmlElement("threshold_amount")]
        public string ThresholdAmount { get; set; }
    }
}
