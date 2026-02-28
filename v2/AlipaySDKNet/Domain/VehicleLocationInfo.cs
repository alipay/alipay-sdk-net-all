using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VehicleLocationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VehicleLocationInfo : AopObject
    {
        /// <summary>
        /// 车身编号,用于车型库匹配获取更多信息
        /// </summary>
        [XmlElement("car_code")]
        public string CarCode { get; set; }

        /// <summary>
        /// 运营商运力类型
        /// </summary>
        [XmlElement("car_level")]
        public string CarLevel { get; set; }

        /// <summary>
        /// 车辆当前所在纬度
        /// </summary>
        [XmlElement("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// 车辆当前所在经度
        /// </summary>
        [XmlElement("lon")]
        public string Lon { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("vehicle_license")]
        public string VehicleLicense { get; set; }

        /// <summary>
        /// 车型id
        /// </summary>
        [XmlElement("vehicle_model_id")]
        public string VehicleModelId { get; set; }
    }
}
