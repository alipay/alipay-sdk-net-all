using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTaxiTripUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTaxiTripUploadModel : AopObject
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("car_no")]
        public string CarNo { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [XmlElement("driver_cert_no")]
        public string DriverCertNo { get; set; }

        /// <summary>
        /// 司机姓名
        /// </summary>
        [XmlElement("driver_name")]
        public string DriverName { get; set; }

        /// <summary>
        /// 当班司机签到时间，hasStandbyDriver=true时建议传入
        /// </summary>
        [XmlElement("driver_sign_in_time")]
        public string DriverSignInTime { get; set; }

        /// <summary>
        /// 行程以外发生金额，单位-元，支持小数点后两位
        /// </summary>
        [XmlElement("extra_amount")]
        public string ExtraAmount { get; set; }

        /// <summary>
        /// 是否有备班司机，只要本车不止一名司机则为true
        /// </summary>
        [XmlElement("has_standby_driver")]
        public bool HasStandbyDriver { get; set; }

        /// <summary>
        /// 低速等候时长 单位-秒
        /// </summary>
        [XmlElement("low_speed_wait_time")]
        public long LowSpeedWaitTime { get; set; }

        /// <summary>
        /// 机具编号
        /// </summary>
        [XmlElement("machine_sn")]
        public string MachineSn { get; set; }

        /// <summary>
        /// 订单总金额，单位-元，支持小数点后两位
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("reserve")]
        public string Reserve { get; set; }

        /// <summary>
        /// 行程发生计费金额，单位-元，支持小数点后两位
        /// </summary>
        [XmlElement("trip_amount")]
        public string TripAmount { get; set; }

        /// <summary>
        /// 行程总时长 单位-秒
        /// </summary>
        [XmlElement("trip_cost_time")]
        public long TripCostTime { get; set; }

        /// <summary>
        /// 行程结束的位置,逗号分隔，经纬度
        /// </summary>
        [XmlElement("trip_end_location")]
        public string TripEndLocation { get; set; }

        /// <summary>
        /// 本次行程结束时间
        /// </summary>
        [XmlElement("trip_end_time")]
        public string TripEndTime { get; set; }

        /// <summary>
        /// 行程唯一Id 由服务商保证单渠道唯一性
        /// </summary>
        [XmlElement("trip_id")]
        public string TripId { get; set; }

        /// <summary>
        /// 行程举例 单位-米
        /// </summary>
        [XmlElement("trip_mileage")]
        public string TripMileage { get; set; }

        /// <summary>
        /// 行程开始的位置,逗号分隔，经纬度
        /// </summary>
        [XmlElement("trip_start_location")]
        public string TripStartLocation { get; set; }

        /// <summary>
        /// 本次行程开始时间
        /// </summary>
        [XmlElement("trip_start_time")]
        public string TripStartTime { get; set; }

        /// <summary>
        /// 行程结束
        /// </summary>
        [XmlElement("trip_type")]
        public string TripType { get; set; }
    }
}
