using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTaxiDriverinfoQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportTaxiDriverinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 年龄
        /// </summary>
        [XmlElement("driver_age")]
        public string DriverAge { get; set; }

        /// <summary>
        /// 司机姓名
        /// </summary>
        [XmlElement("driver_name")]
        public string DriverName { get; set; }

        /// <summary>
        /// 司机支付宝openid
        /// </summary>
        [XmlElement("driver_open_id")]
        public string DriverOpenId { get; set; }

        /// <summary>
        /// 司机支付宝uid
        /// </summary>
        [XmlElement("driver_user_id")]
        public string DriverUserId { get; set; }

        /// <summary>
        /// 返回结果编码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 返回结果描述
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 支付宝唯一司机id
        /// </summary>
        [XmlElement("sys_driver_id")]
        public string SysDriverId { get; set; }
    }
}
