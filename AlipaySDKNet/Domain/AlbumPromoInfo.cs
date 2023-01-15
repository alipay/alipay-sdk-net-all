using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlbumPromoInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AlbumPromoInfo : AopObject
    {
        /// <summary>
        /// 活动结束时间，若有营销活动，则必填
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 营销活动类型：DISCOUNT（折扣）、LIMITED_FREE（限免）等，有则传入。
        /// </summary>
        [XmlElement("promo_type")]
        public string PromoType { get; set; }

        /// <summary>
        /// 活动开始时间，若存在营销活动，则必填
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
