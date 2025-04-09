using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TransferCarData Data Structure.
    /// </summary>
    [Serializable]
    public class TransferCarData : AopObject
    {
        /// <summary>
        /// acid值，车生活的 acid 值，需要传递车生活 acid
        /// </summary>
        [XmlElement("acid")]
        public string Acid { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("activity_end_date")]
        public string ActivityEndDate { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("activity_start_date")]
        public string ActivityStartDate { get; set; }

        /// <summary>
        /// 电池状态, 1 原车买断 2 租用(BaaS) , 默认：0
        /// </summary>
        [XmlElement("attr_car_source_battery_owner_type")]
        public long AttrCarSourceBatteryOwnerType { get; set; }

        /// <summary>
        /// 年检到期时间 YYYYMMDD
        /// </summary>
        [XmlElement("audit_full_date")]
        public string AuditFullDate { get; set; }

        /// <summary>
        /// 车型类型，轿车，MPV
        /// </summary>
        [XmlElement("auto_type")]
        public string AutoType { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 是否品牌官方门店
        /// </summary>
        [XmlElement("brand_official_store")]
        public bool BrandOfficialStore { get; set; }

        /// <summary>
        /// 呼叫号码
        /// </summary>
        [XmlElement("call_phone")]
        public string CallPhone { get; set; }

        /// <summary>
        /// 车颜色： 红色，白色，黑色等
        /// </summary>
        [XmlElement("car_color")]
        public string CarColor { get; set; }

        /// <summary>
        /// 车辆描述
        /// </summary>
        [XmlElement("car_desc")]
        public string CarDesc { get; set; }

        /// <summary>
        /// 钥匙数量，单位个数
        /// </summary>
        [XmlElement("car_keys")]
        public long CarKeys { get; set; }

        /// <summary>
        /// 车辆上线日期
        /// </summary>
        [XmlElement("car_online_date")]
        public string CarOnlineDate { get; set; }

        /// <summary>
        /// 车辆来源：1 国产/ 2 进口
        /// </summary>
        [XmlElement("car_source_type")]
        public long CarSourceType { get; set; }

        /// <summary>
        /// tag标签数组
        /// </summary>
        [XmlArray("car_tags")]
        [XmlArrayItem("string")]
        public List<string> CarTags { get; set; }

        /// <summary>
        /// 车型年款, 单位： 年数据。比如 2023,2024,2025
        /// </summary>
        [XmlElement("car_year")]
        public long CarYear { get; set; }

        /// <summary>
        /// 检查报告内容明细 DTO
        /// </summary>
        [XmlElement("check_report_data")]
        public CheckReportData CheckReportData { get; set; }

        /// <summary>
        /// 车源地；行政区城市编码值
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 排量,车辆的指标, 单位 L 或者 T
        /// </summary>
        [XmlElement("displacement")]
        public string Displacement { get; set; }

        /// <summary>
        /// 行驶里程（单位：公里）
        /// </summary>
        [XmlElement("drive_distance")]
        public long DriveDistance { get; set; }

        /// <summary>
        /// 排放标准，车辆的牌放标准，国六等
        /// </summary>
        [XmlElement("emission_standard")]
        public string EmissionStandard { get; set; }

        /// <summary>
        /// 燃油类型，汽油，柴油，纯电动
        /// </summary>
        [XmlElement("fuel_type")]
        public string FuelType { get; set; }

        /// <summary>
        /// 封面图片
        /// </summary>
        [XmlElement("full_img_url")]
        public string FullImgUrl { get; set; }

        /// <summary>
        /// 亮点数据
        /// </summary>
        [XmlArray("highlights")]
        [XmlArrayItem("string")]
        public List<string> Highlights { get; set; }

        /// <summary>
        /// 车辆图片
        /// </summary>
        [XmlArray("images_url")]
        [XmlArrayItem("string")]
        public List<string> ImagesUrl { get; set; }

        /// <summary>
        /// 交强险到期日期 yyyymmdd
        /// </summary>
        [XmlElement("insurance_full_date")]
        public string InsuranceFullDate { get; set; }

        /// <summary>
        /// 外部数据更新时间
        /// </summary>
        [XmlElement("isv_update_date")]
        public string IsvUpdateDate { get; set; }

        /// <summary>
        /// 首次上牌时间 YYYYMMDD
        /// </summary>
        [XmlElement("license_full_date")]
        public string LicenseFullDate { get; set; }

        /// <summary>
        /// 车辆性质  默认 1 ，1 非营业，2 营业
        /// </summary>
        [XmlElement("operation_type")]
        public long OperationType { get; set; }

        /// <summary>
        /// 车 id
        /// </summary>
        [XmlElement("out_id")]
        public string OutId { get; set; }

        /// <summary>
        /// 价格-分
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// 出厂日期YYYYMM
        /// </summary>
        [XmlElement("product_date")]
        public string ProductDate { get; set; }

        /// <summary>
        /// 座位数,单位： 个
        /// </summary>
        [XmlElement("seats")]
        public long Seats { get; set; }

        /// <summary>
        /// 车系名称
        /// </summary>
        [XmlElement("series_name")]
        public string SeriesName { get; set; }

        /// <summary>
        /// title，车辆展示数据的名称。 比如：蔚来 et5t 签名款 2024 款
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 过户次数，车辆的过户次数，单位：次
        /// </summary>
        [XmlElement("transfer_count")]
        public long TransferCount { get; set; }

        /// <summary>
        /// YYYYMMDD 过户时间
        /// </summary>
        [XmlElement("transfer_date")]
        public string TransferDate { get; set; }

        /// <summary>
        /// 变速器类型，手动MT和自动AT
        /// </summary>
        [XmlElement("transmission_type")]
        public string TransmissionType { get; set; }

        /// <summary>
        /// 商户车辆展示状态  0 下线态  1 上线态/待活动态度 2 活动中  3 活动结束
        /// </summary>
        [XmlElement("vehicle_display_status")]
        public long VehicleDisplayStatus { get; set; }

        /// <summary>
        /// 车辆 video url 地址
        /// </summary>
        [XmlElement("vehicle_video_url")]
        public string VehicleVideoUrl { get; set; }

        /// <summary>
        /// 车辆识别代码（VIN）
        /// </summary>
        [XmlElement("vin")]
        public string Vin { get; set; }
    }
}
