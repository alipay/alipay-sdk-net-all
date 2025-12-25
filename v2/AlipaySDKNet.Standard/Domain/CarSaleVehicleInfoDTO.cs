using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarSaleVehicleInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CarSaleVehicleInfoDTO : AopObject
    {
        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 车辆年限
        /// </summary>
        [XmlElement("car_age")]
        public long CarAge { get; set; }

        /// <summary>
        /// 行驶里程, 单位：公里
        /// </summary>
        [XmlElement("drive_distance_km")]
        public long DriveDistanceKm { get; set; }

        /// <summary>
        /// 车型名称
        /// </summary>
        [XmlElement("model_name")]
        public string ModelName { get; set; }

        /// <summary>
        /// 车系名称
        /// </summary>
        [XmlElement("series_name")]
        public string SeriesName { get; set; }
    }
}
