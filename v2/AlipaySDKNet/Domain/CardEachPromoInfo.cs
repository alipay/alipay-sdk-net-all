using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardEachPromoInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CardEachPromoInfo : AopObject
    {
        /// <summary>
        /// 每期优惠价，单位分
        /// </summary>
        [XmlElement("each_promo_price")]
        public long EachPromoPrice { get; set; }

        /// <summary>
        /// 期数，根据cycle_type确定单位，如周，天，月
        /// </summary>
        [XmlElement("period")]
        public long Period { get; set; }
    }
}
