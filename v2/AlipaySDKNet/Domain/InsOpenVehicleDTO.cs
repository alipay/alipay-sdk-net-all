using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsOpenVehicleDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsOpenVehicleDTO : AopObject
    {
        /// <summary>
        /// 车辆品牌
        /// </summary>
        [XmlElement("vehicle_brand")]
        public string VehicleBrand { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        [XmlElement("vehicle_frame_no")]
        public string VehicleFrameNo { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("vehicle_no")]
        public string VehicleNo { get; set; }

        /// <summary>
        /// 车辆行驶证
        /// </summary>
        [XmlElement("vehicle_registration")]
        public string VehicleRegistration { get; set; }

        /// <summary>
        /// 车辆类型
        /// </summary>
        [XmlElement("vehicle_type")]
        public string VehicleType { get; set; }
    }
}
