using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTaxiDriverinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTaxiDriverinfoQueryModel : AopObject
    {
        /// <summary>
        /// 司机身份证号码
        /// </summary>
        [XmlElement("driver_cert_no")]
        public string DriverCertNo { get; set; }

        /// <summary>
        /// 请求时间，Unix Timestamp单位毫秒
        /// </summary>
        [XmlElement("request_time")]
        public string RequestTime { get; set; }
    }
}
