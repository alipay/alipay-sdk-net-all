using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpPromoInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OpPromoInfo : AopObject
    {
        /// <summary>
        /// 优惠数量
        /// </summary>
        [XmlElement("promo_cnt")]
        public long PromoCnt { get; set; }

        /// <summary>
        /// 优惠补充说明
        /// </summary>
        [XmlElement("promo_desc")]
        public string PromoDesc { get; set; }

        /// <summary>
        /// 优惠到期时间
        /// </summary>
        [XmlElement("promo_expired_time")]
        public string PromoExpiredTime { get; set; }

        /// <summary>
        /// 优惠id
        /// </summary>
        [XmlElement("promo_id")]
        public string PromoId { get; set; }

        /// <summary>
        /// 优惠名称
        /// </summary>
        [XmlElement("promo_name")]
        public string PromoName { get; set; }

        /// <summary>
        /// 单个优惠价值，单位为元
        /// </summary>
        [XmlElement("promo_price")]
        public string PromoPrice { get; set; }

        /// <summary>
        /// 优惠类型
        /// </summary>
        [XmlElement("promo_type")]
        public string PromoType { get; set; }

        /// <summary>
        /// 优惠数量单位，如个、份
        /// </summary>
        [XmlElement("promo_unit")]
        public string PromoUnit { get; set; }
    }
}
