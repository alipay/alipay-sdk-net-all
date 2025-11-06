using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarfinMortgageVehicleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CarfinMortgageVehicleInfo : AopObject
    {
        /// <summary>
        /// 车辆品牌
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 车辆车型
        /// </summary>
        [XmlElement("model_name")]
        public string ModelName { get; set; }

        /// <summary>
        /// 车辆车系名称
        /// </summary>
        [XmlElement("series_name")]
        public string SeriesName { get; set; }
    }
}
