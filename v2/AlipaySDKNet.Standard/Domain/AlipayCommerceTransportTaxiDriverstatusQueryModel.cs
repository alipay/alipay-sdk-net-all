using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTaxiDriverstatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTaxiDriverstatusQueryModel : AopObject
    {
        /// <summary>
        /// 请求时间，Unix Timestamp单位毫秒
        /// </summary>
        [XmlElement("request_time")]
        public string RequestTime { get; set; }

        /// <summary>
        /// 支付宝域内唯一司机id
        /// </summary>
        [XmlElement("sys_driver_id")]
        public string SysDriverId { get; set; }
    }
}
