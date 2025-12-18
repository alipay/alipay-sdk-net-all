using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VehicleDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VehicleDetailInfo : AopObject
    {
        /// <summary>
        /// 车辆编码
        /// </summary>
        [XmlElement("car_code")]
        public string CarCode { get; set; }

        /// <summary>
        /// 车型图片
        /// </summary>
        [XmlElement("car_image")]
        public string CarImage { get; set; }

        /// <summary>
        /// 车辆标签
        /// </summary>
        [XmlElement("car_label")]
        public string CarLabel { get; set; }

        /// <summary>
        /// 车辆等级code 参考 1,经济型 2,舒适型 3,豪华型
        /// </summary>
        [XmlElement("car_level")]
        public string CarLevel { get; set; }

        /// <summary>
        /// 车辆型号id
        /// </summary>
        [XmlElement("car_model_id")]
        public string CarModelId { get; set; }

        /// <summary>
        /// 车级名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 车辆颜色
        /// </summary>
        [XmlElement("vehicle_color")]
        public string VehicleColor { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("vehicle_license")]
        public string VehicleLicense { get; set; }

        /// <summary>
        /// 车品牌名称
        /// </summary>
        [XmlElement("vehicle_make")]
        public string VehicleMake { get; set; }
    }
}
