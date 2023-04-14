using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DriverCarInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DriverCarInfo : AopObject
    {
        /// <summary>
        /// 是否开通高德聚合码 "0"-未开通 "1"-开通
        /// </summary>
        [XmlElement("aggregate_code_flag")]
        public string AggregateCodeFlag { get; set; }

        /// <summary>
        /// 认证时间
        /// </summary>
        [XmlElement("bind_time")]
        public string BindTime { get; set; }

        /// <summary>
        /// 车辆品牌
        /// </summary>
        [XmlElement("car_brand")]
        public string CarBrand { get; set; }

        /// <summary>
        /// 车辆颜色
        /// </summary>
        [XmlElement("car_color")]
        public string CarColor { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("car_no")]
        public string CarNo { get; set; }

        /// <summary>
        /// 车牌颜色
        /// </summary>
        [XmlElement("car_no_color")]
        public string CarNoColor { get; set; }

        /// <summary>
        /// 运营卡号
        /// </summary>
        [XmlElement("car_operation_no")]
        public string CarOperationNo { get; set; }

        /// <summary>
        /// 车辆型号
        /// </summary>
        [XmlElement("car_type")]
        public string CarType { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 城市码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 城市名
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 所属公司
        /// </summary>
        [XmlElement("company")]
        public string Company { get; set; }

        /// <summary>
        /// 司机id
        /// </summary>
        [XmlElement("driver_id")]
        public string DriverId { get; set; }

        /// <summary>
        /// 司机姓名
        /// </summary>
        [XmlElement("driver_name")]
        public string DriverName { get; set; }

        /// <summary>
        /// 司机性别 M-男 F-女
        /// </summary>
        [XmlElement("driver_sex")]
        public string DriverSex { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        [XmlElement("driver_user_id")]
        public string DriverUserId { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [XmlElement("tele_no")]
        public string TeleNo { get; set; }
    }
}
