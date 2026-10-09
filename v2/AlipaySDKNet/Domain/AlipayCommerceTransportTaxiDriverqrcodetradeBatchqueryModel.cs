using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTaxiDriverqrcodetradeBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTaxiDriverqrcodetradeBatchqueryModel : AopObject
    {
        /// <summary>
        /// 批量开始时间
        /// </summary>
        [XmlElement("begin_time")]
        public string BeginTime { get; set; }

        /// <summary>
        /// 支付宝司机uid
        /// </summary>
        [XmlElement("driver_user_id")]
        public string DriverUserId { get; set; }

        /// <summary>
        /// 批量结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }
    }
}
