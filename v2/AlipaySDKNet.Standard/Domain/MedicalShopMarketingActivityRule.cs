using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalShopMarketingActivityRule Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalShopMarketingActivityRule : AopObject
    {
        /// <summary>
        /// 活动满减金额，减多少。单位：分
        /// </summary>
        [XmlElement("reduce_price")]
        public long ReducePrice { get; set; }

        /// <summary>
        /// 活动满减门槛，满多少，单位：分
        /// </summary>
        [XmlElement("reduce_price_threshold")]
        public long ReducePriceThreshold { get; set; }
    }
}
