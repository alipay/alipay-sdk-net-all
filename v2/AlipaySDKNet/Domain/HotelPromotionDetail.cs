using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HotelPromotionDetail Data Structure.
    /// </summary>
    [Serializable]
    public class HotelPromotionDetail : AopObject
    {
        /// <summary>
        /// 酒店优惠活动金额
        /// </summary>
        [XmlElement("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// 酒店优惠活动type，ota维度唯一
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
