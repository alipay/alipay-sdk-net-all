using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubPrizeDiscountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SubPrizeDiscountInfo : AopObject
    {
        /// <summary>
        /// 有门槛
        /// </summary>
        [XmlElement("exist_discount_threshold")]
        public string ExistDiscountThreshold { get; set; }

        /// <summary>
        /// 红包面额，单位分
        /// </summary>
        [XmlElement("reduce_amount")]
        public long ReduceAmount { get; set; }

        /// <summary>
        /// 门槛，单位分
        /// </summary>
        [XmlElement("threshold_amount")]
        public long ThresholdAmount { get; set; }
    }
}
