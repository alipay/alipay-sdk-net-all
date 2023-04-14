using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTaxiDriverauthstatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTaxiDriverauthstatusQueryModel : AopObject
    {
        /// <summary>
        /// 司机支付宝uid
        /// </summary>
        [XmlElement("driver_user_id")]
        public string DriverUserId { get; set; }

        /// <summary>
        /// 请求时间
        /// </summary>
        [XmlElement("request_time")]
        public string RequestTime { get; set; }
    }
}
