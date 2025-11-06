using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CarInfo : AopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 车辆品牌
        /// </summary>
        [XmlElement("car_brand")]
        public string CarBrand { get; set; }

        /// <summary>
        /// 车辆品牌id
        /// </summary>
        [XmlElement("car_brand_id")]
        public string CarBrandId { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("car_license")]
        public string CarLicense { get; set; }

        /// <summary>
        /// 车型来源（车型id的来源）
        /// </summary>
        [XmlElement("car_model_source")]
        public string CarModelSource { get; set; }

        /// <summary>
        /// 车辆车系
        /// </summary>
        [XmlElement("car_series")]
        public string CarSeries { get; set; }

        /// <summary>
        /// 车辆车系id
        /// </summary>
        [XmlElement("car_series_id")]
        public string CarSeriesId { get; set; }

        /// <summary>
        /// 车辆型号
        /// </summary>
        [XmlElement("car_type")]
        public string CarType { get; set; }

        /// <summary>
        /// 车辆型号id
        /// </summary>
        [XmlElement("car_type_id")]
        public string CarTypeId { get; set; }

        /// <summary>
        /// 车架号（车辆识别代码）
        /// </summary>
        [XmlElement("car_vin")]
        public string CarVin { get; set; }

        /// <summary>
        /// 发动机号码
        /// </summary>
        [XmlElement("engine_no")]
        public string EngineNo { get; set; }

        /// <summary>
        /// 首次注册日期，格式：yyyy-MM-dd
        /// </summary>
        [XmlElement("first_register_date")]
        public string FirstRegisterDate { get; set; }

        /// <summary>
        /// 发证日期，格式：yyyy-MM-dd
        /// </summary>
        [XmlElement("issue_date")]
        public string IssueDate { get; set; }

        /// <summary>
        /// 车辆所有人
        /// </summary>
        [XmlElement("owner")]
        public string Owner { get; set; }
    }
}
