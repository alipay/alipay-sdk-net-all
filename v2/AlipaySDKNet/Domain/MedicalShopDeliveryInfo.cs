using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalShopDeliveryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalShopDeliveryInfo : AopObject
    {
        /// <summary>
        /// 多点位按顺时针顺序，首位点位必须相同
        /// </summary>
        [XmlArray("delivery_area")]
        [XmlArrayItem("medical_shop_delivery_point")]
        public List<MedicalShopDeliveryPoint> DeliveryArea { get; set; }

        /// <summary>
        /// 1 - 多边形；2 - 圆形
        /// </summary>
        [XmlElement("delivery_area_type")]
        public long DeliveryAreaType { get; set; }

        /// <summary>
        /// 单位：分
        /// </summary>
        [XmlElement("delivery_fee")]
        public long DeliveryFee { get; set; }

        /// <summary>
        /// 单位：米；圆心为门店位置经纬度
        /// </summary>
        [XmlElement("delivery_radius")]
        public long DeliveryRadius { get; set; }

        /// <summary>
        /// 多个时间段按当天的从早到晚顺序，不能重叠、不能跨天；最多6个时间段
        /// </summary>
        [XmlArray("effective_period")]
        [XmlArrayItem("medical_shop_time_period")]
        public List<MedicalShopTimePeriod> EffectivePeriod { get; set; }

        /// <summary>
        /// 单位：分
        /// </summary>
        [XmlElement("start_price")]
        public long StartPrice { get; set; }

        /// <summary>
        /// 特殊时段配送价加价规则，不跨天, 默认为全天,多个时间段按当天的从早到晚顺序，最多6个时间段，结束时间必须大于起始时间 所属的时间段不能有重叠
        /// </summary>
        [XmlArray("time_ext_fee")]
        [XmlArrayItem("medical_shop_delivery_special_time_price")]
        public List<MedicalShopDeliverySpecialTimePrice> TimeExtFee { get; set; }

        /// <summary>
        /// 特殊时间段起送价加价规则， 不跨天,默认为全天,多个时间段按当天的从早到晚顺序，最多6个时间段 结束时间必须大于起始时间； 所属的时间段不能有重叠
        /// </summary>
        [XmlArray("time_ext_price")]
        [XmlArrayItem("medical_shop_delivery_special_time_price")]
        public List<MedicalShopDeliverySpecialTimePrice> TimeExtPrice { get; set; }
    }
}
