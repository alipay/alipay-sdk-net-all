using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTaxiDriverlevelQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportTaxiDriverlevelQueryResponse : AopResponse
    {
        /// <summary>
        /// 数据版本 YYYYMMDD格式
        /// </summary>
        [XmlElement("date_version")]
        public string DateVersion { get; set; }

        /// <summary>
        /// 司机等级
        /// </summary>
        [XmlElement("driver_level")]
        public string DriverLevel { get; set; }

        /// <summary>
        /// 司机手机号
        /// </summary>
        [XmlElement("driver_phone")]
        public string DriverPhone { get; set; }

        /// <summary>
        /// 错误吗
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 两个状态，我们的库里有该司机：FOUND；我们的库里没有该司机或司机未授权：NOTFOUND。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
