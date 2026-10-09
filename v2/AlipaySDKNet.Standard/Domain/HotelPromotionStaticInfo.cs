using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HotelPromotionStaticInfo Data Structure.
    /// </summary>
    [Serializable]
    public class HotelPromotionStaticInfo : AopObject
    {
        /// <summary>
        /// 酒店优惠活动副标题，名称的补充
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 酒店优惠活动名称
        /// </summary>
        [XmlElement("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// 酒店促销活动类型，ota维度唯一
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
