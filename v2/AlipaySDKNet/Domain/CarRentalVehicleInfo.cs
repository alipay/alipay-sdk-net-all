using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarRentalVehicleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CarRentalVehicleInfo : AopObject
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("car_no")]
        public string CarNo { get; set; }

        /// <summary>
        /// 排量
        /// </summary>
        [XmlElement("vehicle_capacity")]
        public string VehicleCapacity { get; set; }

        /// <summary>
        /// 颜色
        /// </summary>
        [XmlElement("vehicle_color")]
        public string VehicleColor { get; set; }

        /// <summary>
        /// 车辆型号
        /// </summary>
        [XmlElement("vehicle_models")]
        public string VehicleModels { get; set; }

        /// <summary>
        /// 厢数
        /// </summary>
        [XmlElement("vehicle_number")]
        public string VehicleNumber { get; set; }

        /// <summary>
        /// 操作类型 手动挡/自动挡
        /// </summary>
        [XmlElement("vehicle_operation_type")]
        public string VehicleOperationType { get; set; }

        /// <summary>
        /// 座位数
        /// </summary>
        [XmlElement("vehicle_seats")]
        public string VehicleSeats { get; set; }

        /// <summary>
        /// 车辆分类 经济型/舒适型/豪华型
        /// </summary>
        [XmlElement("vehicle_type")]
        public string VehicleType { get; set; }
    }
}
