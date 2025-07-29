using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalRegisterPayfinishNotifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalRegisterPayfinishNotifyResponse : AopResponse
    {
        /// <summary>
        /// 退款中
        /// </summary>
        [XmlElement("order_pay_status")]
        public string OrderPayStatus { get; set; }
    }
}
