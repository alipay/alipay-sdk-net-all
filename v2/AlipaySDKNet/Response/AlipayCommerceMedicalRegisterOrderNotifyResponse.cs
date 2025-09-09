using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalRegisterOrderNotifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalRegisterOrderNotifyResponse : AopResponse
    {
        /// <summary>
        /// 支付宝订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 排班id
        /// </summary>
        [XmlElement("register_id")]
        public string RegisterId { get; set; }
    }
}
