using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTaxiOrderlistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTaxiOrderlistQueryModel : AopObject
    {
        /// <summary>
        /// 查询结束时间，未填默认取当前时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 乘客open_id
        /// </summary>
        [XmlElement("passenger_open_id")]
        public string PassengerOpenId { get; set; }

        /// <summary>
        /// 乘客userId
        /// </summary>
        [XmlElement("passenger_user_id")]
        public string PassengerUserId { get; set; }

        /// <summary>
        /// 查询起始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
