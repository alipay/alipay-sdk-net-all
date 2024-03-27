using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarResponse Data Structure.
    /// </summary>
    [Serializable]
    public class CarResponse : AopObject
    {
        /// <summary>
        /// 车辆品牌
        /// </summary>
        [XmlElement("car_brand")]
        public string CarBrand { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 车辆类型 Car/小型汽车, E_Car/新能源小型汽车, Veh/大型汽车, E_Veh/新能源大型汽车, Van/两三轮摩托车, Other/其他
        /// </summary>
        [XmlElement("vehicle_type")]
        public string VehicleType { get; set; }

        /// <summary>
        /// 车架号ID
        /// </summary>
        [XmlElement("vin")]
        public string Vin { get; set; }
    }
}
