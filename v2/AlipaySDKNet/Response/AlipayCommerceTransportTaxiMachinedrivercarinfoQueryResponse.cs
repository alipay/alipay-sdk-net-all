using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTaxiMachinedrivercarinfoQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportTaxiMachinedrivercarinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 车辆颜色
        /// </summary>
        [XmlElement("car_color")]
        public string CarColor { get; set; }

        /// <summary>
        /// 司机所在城市
        /// </summary>
        [XmlElement("driver_city")]
        public string DriverCity { get; set; }

        /// <summary>
        /// 司机姓名
        /// </summary>
        [XmlElement("driver_name")]
        public string DriverName { get; set; }

        /// <summary>
        /// 司机手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 司机车牌号
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 车辆座位数
        /// </summary>
        [XmlElement("seats")]
        public string Seats { get; set; }

        /// <summary>
        /// 司机性别，男/女
        /// </summary>
        [XmlElement("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// 司机是否已签到，T/F
        /// </summary>
        [XmlElement("sign_status")]
        public string SignStatus { get; set; }

        /// <summary>
        /// 支付宝司机唯一id
        /// </summary>
        [XmlElement("sys_driver_id")]
        public string SysDriverId { get; set; }
    }
}
