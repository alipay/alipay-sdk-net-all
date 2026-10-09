using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTaxiDriverqrcodetradeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTaxiDriverqrcodetradeQueryModel : AopObject
    {
        /// <summary>
        /// 交易开始时间
        /// </summary>
        [XmlElement("begin_time")]
        public string BeginTime { get; set; }

        /// <summary>
        /// 支付宝open_id
        /// </summary>
        [XmlElement("driver_open_id")]
        public string DriverOpenId { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        [XmlElement("driver_user_id")]
        public string DriverUserId { get; set; }

        /// <summary>
        /// 交易结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }
    }
}
