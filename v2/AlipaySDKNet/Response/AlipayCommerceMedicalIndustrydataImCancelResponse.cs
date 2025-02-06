using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataImCancelResponse.
    /// </summary>
    public class AlipayCommerceMedicalIndustrydataImCancelResponse : AopResponse
    {
        /// <summary>
        /// 支付宝im消息id
        /// </summary>
        [XmlElement("alipay_msg_id")]
        public string AlipayMsgId { get; set; }
    }
}
