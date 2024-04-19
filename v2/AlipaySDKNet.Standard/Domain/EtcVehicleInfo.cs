using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EtcVehicleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EtcVehicleInfo : AopObject
    {
        /// <summary>
        /// 车辆发动机号码
        /// </summary>
        [XmlElement("engine_no")]
        public string EngineNo { get; set; }

        /// <summary>
        /// 0：蓝； 1：黄；  2：黑； 3：白； 4：渐变绿
        /// </summary>
        [XmlElement("plate_color")]
        public string PlateColor { get; set; }

        /// <summary>
        /// 车牌号码
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 核定载人数，不带单位
        /// </summary>
        [XmlElement("vi_ac")]
        public string ViAc { get; set; }

        /// <summary>
        /// 行驶证发证日期
        /// </summary>
        [XmlElement("vi_grant_date")]
        public string ViGrantDate { get; set; }

        /// <summary>
        /// 总质量
        /// </summary>
        [XmlElement("vi_gross_mass")]
        public string ViGrossMass { get; set; }

        /// <summary>
        /// 车高
        /// </summary>
        [XmlElement("vi_height")]
        public string ViHeight { get; set; }

        /// <summary>
        /// 车长
        /// </summary>
        [XmlElement("vi_length")]
        public string ViLength { get; set; }

        /// <summary>
        /// 行驶证上的品牌型号
        /// </summary>
        [XmlElement("vi_model_name")]
        public string ViModelName { get; set; }

        /// <summary>
        /// 车辆所有人
        /// </summary>
        [XmlElement("vi_owner_name")]
        public string ViOwnerName { get; set; }

        /// <summary>
        /// 车辆注册日期
        /// </summary>
        [XmlElement("vi_register_date")]
        public string ViRegisterDate { get; set; }

        /// <summary>
        /// 车辆类型，OCR识别信息，例如小型普通客车
        /// </summary>
        [XmlElement("vi_type")]
        public string ViType { get; set; }

        /// <summary>
        /// 运营/非营运
        /// </summary>
        [XmlElement("vi_use_type")]
        public string ViUseType { get; set; }

        /// <summary>
        /// 车辆识别号
        /// </summary>
        [XmlElement("vi_vin")]
        public string ViVin { get; set; }

        /// <summary>
        /// 车宽
        /// </summary>
        [XmlElement("vi_width")]
        public string ViWidth { get; set; }
    }
}
