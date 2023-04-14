using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTaxiDrivermachineBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTaxiDrivermachineBindModel : AopObject
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("car_no")]
        public string CarNo { get; set; }

        /// <summary>
        /// 城市码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("driver_open_id")]
        public string DriverOpenId { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("driver_user_id")]
        public string DriverUserId { get; set; }

        /// <summary>
        /// 签到时间
        /// </summary>
        [XmlElement("gmt_signin")]
        public string GmtSignin { get; set; }

        /// <summary>
        /// 签到位置点信息
        /// </summary>
        [XmlElement("location_info")]
        public GPSLocationInfo LocationInfo { get; set; }

        /// <summary>
        /// 机具sn
        /// </summary>
        [XmlElement("machine_sn")]
        public string MachineSn { get; set; }

        /// <summary>
        /// 机具供应商id
        /// </summary>
        [XmlElement("machine_supplier_id")]
        public string MachineSupplierId { get; set; }

        /// <summary>
        /// 请求id,保证全局唯一性
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
