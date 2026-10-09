using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarDialogonlineVehicleQueryResponse.
    /// </summary>
    public class AlipayEcoMycarDialogonlineVehicleQueryResponse : AopResponse
    {
        /// <summary>
        /// 生产年份，格式：yyyy
        /// </summary>
        [XmlElement("factory_date")]
        public string FactoryDate { get; set; }

        /// <summary>
        /// 车型库ID
        /// </summary>
        [XmlElement("lib_id")]
        public string LibId { get; set; }

        /// <summary>
        /// 生产厂商
        /// </summary>
        [XmlElement("manufacturer")]
        public string Manufacturer { get; set; }

        /// <summary>
        /// 常驻城市的编码
        /// </summary>
        [XmlElement("resident_city")]
        public string ResidentCity { get; set; }

        /// <summary>
        /// 车辆品牌
        /// </summary>
        [XmlElement("vi_brand")]
        public string ViBrand { get; set; }

        /// <summary>
        /// 发动机排量
        /// </summary>
        [XmlElement("vi_cc")]
        public string ViCc { get; set; }

        /// <summary>
        /// 车辆ID
        /// </summary>
        [XmlElement("vi_id")]
        public string ViId { get; set; }

        /// <summary>
        /// 行驶里程
        /// </summary>
        [XmlElement("vi_mileage")]
        public string ViMileage { get; set; }

        /// <summary>
        /// 车型
        /// </summary>
        [XmlElement("vi_model")]
        public string ViModel { get; set; }

        /// <summary>
        /// 车系
        /// </summary>
        [XmlElement("vi_series")]
        public string ViSeries { get; set; }

        /// <summary>
        /// 上路时间，格式：yyyy-mm-dd
        /// </summary>
        [XmlElement("vi_time")]
        public string ViTime { get; set; }
    }
}
